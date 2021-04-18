using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventPlanner.Models
{
    public class EventTypeModel
    {
        [Key]
        [Display(Name="Event Type Id")]
        public int EventType_id { get; set; }

        [Required(ErrorMessage ="Event Type must be Added.")]
        [Display(Name ="Event Type")]
        public string EventType { get; set; }
    }
}
