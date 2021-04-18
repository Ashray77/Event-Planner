using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EventPlanner.Models
{
    public class Booking
    {
        [Key]
        public int Booking_id { get; set; }

        

        [Required(ErrorMessage ="User Must be Specified.")]
        [ForeignKey("User_id")]
        public virtual UserAccount UsrAcc { get; set; }

        [Required(ErrorMessage = "Event Type Must be Specified.")]
        //[ForeignKey("EventType_id")]
        public string eventType { get; set; }
        public IEnumerable<SelectListItem> EventTypeList { get; set; }


        [Required(ErrorMessage ="Event Shift Must Be Specified.")]
        public string EventShift { get; set; }

        [Required(ErrorMessage ="Event Date Must be Specified.")]
        [DataType(DataType.Date)]
        public string EventDate { get; set; }

        [Required(ErrorMessage ="Number of Guest Mues be Specified.")]
        [Range(500, 1500, ErrorMessage = "Number of Guest Must be Bettween 500 to 1500")]
        public int NumberofGuest { get; set; }

        [Required(ErrorMessage ="Venue Must Be Specified.")]
        [ForeignKey("Venue_id")]
        public virtual Venue Ven { get; set; }

        [ForeignKey("Design_id")]
        public virtual Design Des { get; set; }

        [ForeignKey("Menu_id")]
        public virtual Menu Men { get; set; }

        public string ExtraDescription { get; set; }

    }
}
