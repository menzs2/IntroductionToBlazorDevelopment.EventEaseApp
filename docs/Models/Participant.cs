﻿using System.ComponentModel.DataAnnotations;

namespace EventEaseApp
{
    public class Participant
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        [Required (ErrorMessage= "Last Name is required")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public bool IsRegistered { get; set; } //not currently used
        public DateTime RegistrationDate { get; set; } //not currently used
    }
}
