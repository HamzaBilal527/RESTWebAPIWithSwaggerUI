using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesManager.Core.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Person Name cant be black")]
        public string PersonName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email cant be blank")]

        [EmailAddress(ErrorMessage = "Email should be in proper format")]
        
        [Remote(action: "IsEmailAlreadyRegistered", controller: "Account", ErrorMessage = "Email is already in use")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone Number cant be blank")]

        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone should be in proper format")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password cant be blank")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirm Password cant be blank")]

        [Compare("Password", ErrorMessage = "Password and Confirm Password must match")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
