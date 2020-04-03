using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Web.Data;
using Web.Models;
using Web.Models.Domain;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly int _managedElectionID;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
            _managedElectionID = _context.StateSingleton.Find(State.STATE_ID).ManagedElectionID;
        }

        public IActionResult Index()
        {
            State s = _context.StateSingleton.Find(State.STATE_ID);
            Election e = _context.Elections.Where(el => el.ElectionId == _managedElectionID).First();
            DashboardViewModel dashboard = new DashboardViewModel
            {
                ElectionName = e.ElectionName,
                CandidatesCount = _context.Candidates
                    .Where(c => c.ElectionId == _managedElectionID)
                    .Count(),
                BallotIssuesCount = _context.BallotIssues
                    .Where(c => c.ElectionId == _managedElectionID)
                    .Count(),
                PollingPlacesCount = _context.PollingPlaces
                    .Where(c => c.ElectionId == _managedElectionID)
                    .Count(),
                RacesCount = _context.Races
                    .Where(c => c.RaceId == _managedElectionID)
                    .Count(),
                ThemesCount = _context.Themes
                    // .Where(c => c.T == _managedElectionID)
                    .Count(),
                StatesCount = _context.StateSingleton
                    .Where(c => c.StateId == _managedElectionID)
                    .Count(),
                ElectionsCount = _context.Elections
                    .Where(c => c.ElectionId == _managedElectionID)
                    .Count(),
                OpenGraphsCount = _context.OpenGraph
                    .Where(c => c.OpenGraphId == _managedElectionID)
                    .Count(),
                OrganizationsCount = _context.Organizations
                    .Where(c => c.OrganizationId == _managedElectionID)
                    .Count(),
                SocialMediasCount = _context.SocialMedias
                    // .Where(c => c. == _managedElectionID)
                    .Count()
            };

            return View(dashboard);
        }

        public void Diagram()
        {
            Response.Redirect("../diagram.html");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1), IsEssential = true }
                // isEssential = true is necessary here to possibly bypass consent policy check, otherwise, the culture might
                // not be switched properly
            );

            return LocalRedirect(returnUrl);
        }
    }
}