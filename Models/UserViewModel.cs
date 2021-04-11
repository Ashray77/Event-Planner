using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace EventPlanner.Models
{
    public class UserViewModel
    {
        [Key]
        [Required]
        public int User_id { get; set; }
        [Required]
        public string User_name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string phone { get; set; }
        public string Address { get; set; }
        [Required]
        public string role { get; set; } 
    }
}
