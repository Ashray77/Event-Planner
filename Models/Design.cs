using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models
{
    public class Design
    {
        [Key]
        public int Design_id { get; set; }

        [Required(ErrorMessage = "Enter the Design Theme.")]
        [Display(Name = "Design Theme")]
        public string Design_theme { get; set; }

        [Required(ErrorMessage = "Enter the Design Cost.")]
        [Display(Name = "Design Cost")]
        public string Design_cost { get; set; }

        [Required(ErrorMessage = "Enter the Design description.")]
        [Display(Name = "Design Description")]
        public string Design_description { get; set; }
    }
}
