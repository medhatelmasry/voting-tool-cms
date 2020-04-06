using System.ComponentModel.DataAnnotations;
﻿namespace Web.Models.Configuration
{
    public class Email
    {
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }

        
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
