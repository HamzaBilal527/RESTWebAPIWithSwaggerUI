using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesManager.Core.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email cant be empty")]
        [EmailAddress(ErrorMessage = "Email must be right format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password cant be empty")]
        public string Password { get; set; } = string.Empty;
    }
}
