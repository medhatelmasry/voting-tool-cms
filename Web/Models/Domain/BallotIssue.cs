using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models.Domain
{
    public class BallotIssue
    {
        [Key]
        [Display(Name = "BallotIssueId")]
        public int BallotIssueId { get; set; }

        [Display(Name = "ElectionId")]
        public int ElectionId { get; set; }

        [Display(Name = "Election")]
        public Election Election { get; set; }

        [Display(Name = "BallotIssue")]

        [Required(ErrorMessage = "Please enter a title.")]
        [StringLength(256, MinimumLength = 2, ErrorMessage = "Title must be between 2 and 256 characters in length.")]
        public string BallotIssueTitle { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "BallotIssueOptions")]
        public List<IssueOption> BallotIssueOptions { get; set; }
    }
}
