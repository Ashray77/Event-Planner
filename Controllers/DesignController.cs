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
        
    }
}
