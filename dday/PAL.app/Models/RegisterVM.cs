﻿using System.ComponentModel.DataAnnotations;

namespace PAL.app.Models
{
    public class RegisterVM
    {
        public RegisterVM()
        {
            Email = "";
            Password = "";
            ConfirmPassword = "";

        }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
