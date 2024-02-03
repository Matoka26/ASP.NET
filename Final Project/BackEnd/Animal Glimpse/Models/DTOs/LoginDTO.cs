﻿using System.ComponentModel.DataAnnotations;

namespace Animal_Glimpse.Models.DTOs
{
    public class LoginDTO
    {
        
        public string Email { get; set; }
        //public string UserName {  get; set; }

        [Required]
        public string Password { get; set; }
    }
}
