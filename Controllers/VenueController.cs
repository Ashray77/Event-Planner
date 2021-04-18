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
        public async Task<IActionResult> AddVenue(Venue venue)
        {
            if (ModelState.IsValid)
            {
                _db.Add(venue);
                await _db.SaveChangesAsync();
                return RedirectToAction("ManageVenue");

            }
            return View(venue);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageVenue");
            }
            var getuserdetails = await _db.VenueTable.FindAsync(id);
            return View(getuserdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Venue ven)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ven);
                await _db.SaveChangesAsync();
                return RedirectToAction("ManageVenue");
            }
            return View(ven);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageVenue");
            }
            var getuserdetails = await _db.VenueTable.FindAsync(id);
            return View(getuserdetails);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageVenue");
            }
            var getuserdetails = await _db.VenueTable.FindAsync(id);
            return View(getuserdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getuserdetails = await _db.VenueTable.FindAsync(id);
            _db.VenueTable.Remove(getuserdetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("ManageVenue");

        }
    }
}
