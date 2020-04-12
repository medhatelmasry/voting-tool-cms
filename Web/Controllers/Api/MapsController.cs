using GeoCoordinatePortable;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Options;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using Web.DTO;
using Web.Data;
using Web.Models;
using Web.Models.Configuration;
using Newtonsoft.Json;

namespace Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly HttpClient client = new HttpClient() { BaseAddress = new Uri("https://api.mapbox.com/directions/v5/mapbox/driving/") };
        public static string AccessToken { get; set; }
        public static MapConfiguration MapConfiguration { get; set; }

        // public static async Task<string> GetAccessToken()
        // {
        //     string accessToken = AccessToken;

        //     try
        //     {
        //         if (string.IsNullOrEmpty(accessToken))
        //         {
        //             SecretBundle secret = null;

        //             KeyVaultClient keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(new AzureServiceTokenProvider().KeyVaultTokenCallback));

        //             secret = await keyVaultClient
        //                 .GetSecretAsync($"https://{MapConfiguration.KeyVaultName}.vault.azure.net/secrets/{MapConfiguration.SecretName}")
        //                 .ConfigureAwait(false);

        //             if (secret != null)
        //             {
        //                 accessToken = secret.Value;
        //             }
        //         }
        //     }
        //     catch (KeyVaultErrorException kvee)
        //     {
        //         // TODO
        //     }

        //     return accessToken;
        // }
        



        // simply returns a mapbox api key
        // public static string GetAccessToken() {
        //     return "test_api_key";
        // }


        // gets mapbox api key from appsettings.json
        public static string GetAccessToken() {
            return MapConfiguration.ApiKey;
        }

        public MapsController(ApplicationDbContext context, IOptions<MapConfiguration> mapConfiguration)
        {
            _context = context;

            MapConfiguration = mapConfiguration.Value;

            // AccessToken = GetAccessToken().GetAwaiter().GetResult();
            AccessToken = GetAccessToken();
        }

        // example: /api/maps/-123.1169,49.2710
        [HttpGet("{location}")]
        public async Task<ActionResult<object>> GetClosestLocations(string location)
        {
            var distances = new List<DistanceDTO>();

            try
            {
                double longitude = double.Parse(location.Split(',')[0]);
                double latitude = double.Parse(location.Split(',')[1]);

                Console.WriteLine("longitude = "+longitude);
                Console.WriteLine("latitude = "+latitude);

                var pollingPlaceCoordinate = new GeoCoordinate(latitude, longitude);

                // only works in .net 2.2
                // var nearestPollingPlaces = _context.PollingPlaces
                //                         .Where(pollingPlace => pollingPlace.ElectionId == _context.StateSingleton.First().RunningElectionID)
                //                         .OrderBy(
                //                             pollingPlace => 
                //                                 new GeoCoordinate(pollingPlace.Latitude, pollingPlace.Longitude)
                //                                 .GetDistanceTo(pollingPlaceCoordinate)
                //                         )
                //                         .Take(20)
                //                         .ToList();


                var nearestPollingPlaces = _context.PollingPlaces
                                            .Where(pollingPlace => pollingPlace.ElectionId == _context.StateSingleton.First().RunningElectionID)
                                            
                                            // todo: fix orderby in ef 3.1 syntax
                                            // note: this DOES NOT order by proximity to pollingPlaceCoordinate at the moment
                                            
                                            // .OrderBy(pollingPlace => pollingPlaceCoordinate.Latitude)
                                            .Take(20)
                                            .ToList();

                Console.WriteLine("lat: "+nearestPollingPlaces[0].Latitude+ " long: " + nearestPollingPlaces[0].Longitude);

                foreach (var pollingPlace in nearestPollingPlaces)
                {
                    string getRequestString = $"{longitude},{latitude};" +
                            $"{pollingPlace.Longitude},{pollingPlace.Latitude}" +
                            $"?access_token={AccessToken}";

                    // log the request string                    
                    Console.WriteLine(getRequestString);

                    var response = await client
                        .GetAsync(getRequestString)
                        .ConfigureAwait(false);

                    // log the response
                    Console.WriteLine($"{response}");

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new ArgumentException(response.ReasonPhrase);
                    }

                    
                    var map = JsonConvert.DeserializeObject<Map>(
                        await response.Content
                        .ReadAsStringAsync()
                        .ConfigureAwait(false));

                    // write one found route's duration
                    Console.WriteLine(map.Routes[0].Duration);

                    // add a distanceDTO representing a polling place and its distance (requires valid route from A to B)
                    try {
                        distances.Add(new DistanceDTO
                        {
                            PollingPlaceID = pollingPlace.PollingPlaceId,
                            Distance = map.Routes
                            .Select(routes => routes.Distance)
                            .First(),
                        });
                    // if mapbox has not found any routes, goes to this catch block
                    } catch (InvalidOperationException ioe) {
                        Console.WriteLine("no route found by mapbox");
                        distances.Add(new DistanceDTO{
                            PollingPlaceID = pollingPlace.PollingPlaceId,
                            Distance = 1000000.00, //arbitrarily large number to place it at the bottom of the return list
                        });
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex}");
                return BadRequest(ex);
            }
            catch (FormatException ex)
            {
                return BadRequest(ex);
            }

            return distances.OrderBy(distance => distance.Distance).Take(10).ToList();
        }
    }
}