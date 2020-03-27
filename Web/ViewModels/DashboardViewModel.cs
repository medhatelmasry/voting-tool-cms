using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.ViewModels
{
    public class DashboardViewModel
    {
        public int CandidatesCount { get; set; }
        public int ContactsCount { get; set; }
        public int BallotIssuesCount { get; set; }
        public int PollingPlacesCount { get; set; }
        public int RacesCount { get; set; }
        public int ThemesCount { get; set; }
        public int StatesCount { get; set; }
        public int ElectionsCount { get; set; }
        public int OpenGraphsCount { get; set; }
        public int OrganizationsCount { get; set; }
        public int SocialMediasCount { get; set; }
        public string ElectionName { get; set; }
    }
}
