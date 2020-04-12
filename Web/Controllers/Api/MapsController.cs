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
        
        public string GetAccessToken() {
            return "pk.eyJ1IjoicmVuZWlscGFzY3VhIiwiYSI6ImNrOHVxMmU3ZjBkcHkzc28zMnd2Nm9ud2cifQ.Q_4bZudInkF-NvzWlLxdyQ";
        }
        public MapsController(ApplicationDbContext context, IOptions<MapConfiguration> mapConfiguration)
        {
            _context = context;

            MapConfiguration = mapConfiguration.Value;

            // AccessToken = GetAccessToken().GetAwaiter().GetResult();
            AccessToken = GetAccessToken();
        }

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
                                            .OrderBy(pollingPlace => pollingPlaceCoordinate.Latitude)
                                            .Take(20)
                                            .ToList();

                Console.WriteLine("lat: "+nearestPollingPlaces[0].Latitude+ " long: " + nearestPollingPlaces[0].Longitude);

                foreach (var pollingPlace in nearestPollingPlaces)
                {
                    Console.WriteLine("a1");
                    string getRequestString = $"{longitude},{latitude};" +
                            $"{pollingPlace.Longitude},{pollingPlace.Latitude}" +
                            $"?access_token={AccessToken}";
                    Console.WriteLine(getRequestString);
                    var response = await client
                        .GetAsync(getRequestString)
                        .ConfigureAwait(false);

                    Console.WriteLine("a2");
                    Console.WriteLine($"{response}");
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("F M L");
                        throw new ArgumentException(response.ReasonPhrase);
                    }

                    
                    Console.WriteLine("a3");
                    var map = JsonConvert.DeserializeObject<Map>(
                        await response.Content
                        .ReadAsStringAsync()
                        .ConfigureAwait(false));

                    Console.WriteLine("a4");
                    distances.Add(new DistanceDTO
                    {
                        PollingPlaceID = pollingPlace.PollingPlaceId,
                        Distance = map.Routes
                        .Select(routes => routes.Distance)
                        .First(),
                    });
                    Console.WriteLine("a5");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("uhh");
                Console.WriteLine($"{ex}");
                return BadRequest(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("uhhh");
                return BadRequest(ex);
            }

            return distances.OrderBy(distance => distance.Distance).Take(10).ToList();
        }
    }
}