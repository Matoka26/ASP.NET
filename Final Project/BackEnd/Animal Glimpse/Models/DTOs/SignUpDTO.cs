﻿using System.ComponentModel.DataAnnotations;

namespace Animal_Glimpse.Models.DTOs
{
    public class SignUpDTO
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        public string PhoneNumber {  get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }
     
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
