using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models
{
    public class Venue
    {
        [Key]
        public int Venue_id { get; set; }

        [Required(ErrorMessage ="Enter the Venue Name")]
        [Display(Name ="Venue Name")]
        public string Venue_name { get; set; }

        [Required(ErrorMessage = "Enter the Venue Address")]
        [Display(Name = "Venue Address")]
        public string Venue_Address { get; set; }

        [Required(ErrorMessage = "Enter the Venue Capacity")]
        [Display(Name = "Venue Capacity")]
        public int Venue_capacity { get; set; }

        [Required(ErrorMessage = "Enter the Venue Price")]
        [Display(Name = "Venue Price")]
        public string Venue_price { get; set; }

        [Required(ErrorMessage = "Enter the Venue Description")]
        [Display(Name = "Venue Description")]
        public string venue_description { get; set; }
    }
}
