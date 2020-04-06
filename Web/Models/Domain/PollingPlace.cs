using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Web.Models.Domain
{
    public class PollingPlace
    {
        [Key]
        [Display(Name = "PollingPlaceId")]
        public int PollingPlaceId { get; set; }

        [Display(Name = "ElectionId")]
        public int ElectionId { get; set; }

        [Display(Name = "Election")]
        public Election Election { get; set; }

        [Display(Name = "PollingPlace")]
        public string PollingPlaceName { get; set; }

        [Display(Name = "PollingStation")]
        public string PollingStationName { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter an address.")]
        [StringLength(512, MinimumLength = 2, ErrorMessage = "Address must be between 2 and 512 characters in length.")]
        public string Address { get; set; }

        [Display(Name = "WheelchairInfo")]
        public string WheelchairInfo { get; set; }

        [Display(Name = "ParkingInfo")]
        public string ParkingInfo { get; set; }

        [Display(Name = "Latitude")]
        public double Latitude { get; set; }

        [Display(Name = "Longitude")]
        public double Longitude { get; set; }

        [Display(Name = "AdvanceOnly")]
        public bool AdvanceOnly { get; set; }

        [Display(Name = "LocalArea")]
        public string LocalArea { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "PollingPlaceDates")]
        public List<PollingPlaceDate> PollingPlaceDates { get; set; }
    }
}
