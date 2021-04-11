using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventPlanner.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult BookingRecords()
        {
            return View();
        }

        public IActionResult UserRecords()
        {
            return View();
        }

        public IActionResult ManageVenue()
        {
            return View();
        }

        public IActionResult ManageMenu()
        {
            return View();
        }

        public IActionResult ManageDesign()
        {
            return View();
        }
    }
}
