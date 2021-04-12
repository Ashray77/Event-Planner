using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventPlanner.Models;
using Microsoft.EntityFrameworkCore;


namespace EventPlanner.Controllers
{
    public class VenueController : Controller
    {
        private readonly ApplicationDbContext _db;

        public VenueController(ApplicationDbContext db)
        {
            _db = db; 
        }
        public IActionResult ManageVenue()
        {
            var displaydata = _db.VenueTable.ToList();
            return View(displaydata);
        }

        public IActionResult AddVenue()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddVenue(Venue ven)
        {
            if (ModelState.IsValid)
            {
                _db.Add(ven);
                await _db.SaveChangesAsync();
                return RedirectToAction("ManageVenue");

            }
            return View(ven);
        }
    }
}
