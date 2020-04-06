using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models.Domain
{
    public class Organization
    {
        [Key]
        [Display(Name = "OrganizationId")]
        public int OrganizationId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter a Name.")]
        [StringLength(256, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 256 characters in length.")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Candidates")]
        public List<Candidate> Candidates { get; set; }
    }
}
