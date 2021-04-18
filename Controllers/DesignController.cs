using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace EventPlanner.Controllers
{
    public class DesignController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DesignController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult ManageDesign()
        {
            var displaydata = _db.DesignTable.ToList();
            return View(displaydata);
        }

        public IActionResult AddDesign()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddDesign(Design des)
        {
            if (ModelState.IsValid)
            {
                _db.Add(des);
                await _db.SaveChangesAsync();
                return RedirectToAction("ManageDesign");

            }
            return View(des);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageDesign");
            }
            var getdesigndetails = await _db.DesignTable.FindAsync(id);
            return View(getdesigndetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Design design)
        {
            if (ModelState.IsValid)
            {
                _db.Update(design);
                await _db.SaveChangesAsync();
                return RedirectToAction("ManageDesign");
            }
            return View(design);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageDesign");
            }
            var getdesigndetails = await _db.DesignTable.FindAsync(id);
            return View(getdesigndetails);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageDesign");
            }
            var getdesigndetails = await _db.DesignTable.FindAsync(id);
            return View(getdesigndetails);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getdesigndetails = await _db.DesignTable.FindAsync(id);
            _db.DesignTable.Remove(getdesigndetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("ManageDesign");

        }
    }
}
