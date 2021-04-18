using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Please Enter your Email.")]
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Select Your Role.")]
        [Display(Name = "Role")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Please Enter your Password.")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }

    }
}
