using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EventPlanner.Models
{
    public class UserAccount
    {
        [Key]
        public int User_id { get; set; }

        [Required(ErrorMessage ="First Name is required.")]
        public string First_name { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string Last_name { get; set; }

        [Required(ErrorMessage ="Email is Required.")]
        
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        public string phone { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage ="Role is Required.")]

        public string Role { get; set; }

        [Required(ErrorMessage ="Password is Required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Please Confirm Your Password.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
