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
        [Display(Name ="First Name")]
        public string First_name { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        public string Last_name { get; set; }

        [Required(ErrorMessage ="Email is Required.")]
        [Display(Name = "Emai Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [Display(Name = "Phone Number")]

        public string phone { get; set; }

        [Display(Name ="Address")]
        public string Address { get; set; }

        //[Required(ErrorMessage = "Role Must be Specified.")]
        //[ForeignKey("role_id")]
        //public virtual RoleModel Role { get; set; }

        public string Role { get; set; }
        

        [Required(ErrorMessage ="Password is Required.")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Please Confirm Your Password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
