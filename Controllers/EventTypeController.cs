using EventPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventPlanner.Controllers
{
    public class EventTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EventTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult ManageEventType()
        {
            var displaydata = _db.EventTypeTable.ToList();
            return View(displaydata);
        }

        public IActionResult AddEventType()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEventType(EventTypeModel eventType)
        {
            if (ModelState.IsValid)
            {
                _db.Add(eventType);
                await _db.SaveChangesAsync();
                return RedirectToAction("ManageEventType");

            }
            return View(eventType);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageEventType");
            }
            var geteventdetails = await _db.EventTypeTable.FindAsync(id);
            return View(geteventdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(EventTypeModel eventType)
        {
            if (ModelState.IsValid)
            {
                _db.Update(eventType);
                await _db.SaveChangesAsync();
                return RedirectToAction("ManageEventType");
            }
            return View(eventType);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageEventType");
            }
            var geteventdetails = await _db.EventTypeTable.FindAsync(id);
            return View(geteventdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var geteventdetails = await _db.EventTypeTable.FindAsync(id);
            _db.EventTypeTable.Remove(geteventdetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("ManageEventType");

        }
    }
}
