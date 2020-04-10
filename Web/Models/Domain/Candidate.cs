using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models.Domain
{
    public class Candidate
    {
        [Key]
        [Display(Name = "CandidateId")]
        public int CandidateId { get; set; }

        [Display(Name = "ElectionId")]
        public int ElectionId { get; set; }

        [Display(Name = "Election")]
        public Election Election { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter a Name.")]
        [StringLength(256, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 256 characters in length.")]
        public string Name { get; set; }

        [Display(Name = "Picture")]
        [Required(ErrorMessage = "Please select an image to upload.")]
        [RegularExpression(@"(http(s?):)([/|.|\w|\s|-])*\.(?:jpg|gif|png|jpeg)")]
        public string Picture { get; set; }

        [Display(Name = "CandidateDetails")]
        [Required(ErrorMessage = "Please enter candidate details.")]
        public List<CandidateDetail> Details { get; set; }

        [Display(Name = "OrganizationId")]
        public int OrganizationId { get; set; }

        [Display(Name = "Organization")]
        public Organization Organization { get; set; }

        [Display(Name = "CandidateRaces")]
        public List<CandidateRace> CandidateRaces { get; set; }

        [Display(Name = "Contacts")]
        [Required(ErrorMessage = "Please enter at least one contact.")]
        public List<Contact> Contacts { get; set; }
    }
}
