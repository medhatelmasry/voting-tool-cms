using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Web.Models.Domain;

namespace Web.ViewModels
{
    public class OrganizationViewModel
    {
        [Key]
        [Display(Name = "OrganizationId")]
        public int OrganizationId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Candidates")]
        public List<Candidate> Candidates { get; set; }
    }
}
