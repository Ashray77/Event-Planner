using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models
{
    public class Menu
    {
        [Key]
        public int Menu_id { get; set; }

        [Required(ErrorMessage = "Enter the Menu Name.")]
        [Display(Name = "Menu Name")]
        public string Menu_name { get; set; }

        [Required(ErrorMessage = "Enter the Starter Items.")]
        [Display(Name = "Starter Items")]
        public string Item_starter { get; set; }

        [Required(ErrorMessage = "Enter the Main Course Items.")]
        [Display(Name = "Main Course Items")]
        public string Item_maincourse { get; set; }

        [Required(ErrorMessage = "Enter the Dessert Items.")]
        [Display(Name = "Dessert Items")]
        public string Item_dessert { get; set; }

        [Required(ErrorMessage = "Enter the Menu Price.")]
        [Display(Name = "Menu Price")]
        public string Menu_price { get; set; }

    }
}
