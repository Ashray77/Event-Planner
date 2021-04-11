using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventPlanner.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Booking()
        {
            return View();
        }

        public IActionResult Your_event()
        {
            return View();
        }
    }
}
