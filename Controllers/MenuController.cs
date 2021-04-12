using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace EventPlanner.Controllers
{
    public class MenuController : Controller
    {
       private readonly ApplicationDbContext _db;

            public MenuController(ApplicationDbContext db)
            {
                _db = db;
            }
            public IActionResult ManageMenu()
            {
                var displaydata = _db.MenuTable.ToList();
                return View(displaydata);
            }

            public IActionResult AddMenu()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> AddMenu(Menu menu)
            {
                if (ModelState.IsValid)
                {
                    _db.Add(menu);
                    await _db.SaveChangesAsync();
                    return RedirectToAction("ManageMenu");

                }
                return View(menu);
            }
            
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageMenu");
            }
            var getuserdetails = await _db.MenuTable.FindAsync(id);
            return View(getuserdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Menu mu)
        {
            if (ModelState.IsValid)
            {
                _db.Update(mu);
                await _db.SaveChangesAsync();
                return RedirectToAction("ManageMenu");
            }
            return View(mu);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageMenu");
            }
            var getuserdetails = await _db.MenuTable.FindAsync(id);
            return View(getuserdetails);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageMenu");
            }
            var getuserdetails = await _db.MenuTable.FindAsync(id);
            return View(getuserdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getuserdetails = await _db.MenuTable.FindAsync(id);
            _db.MenuTable.Remove(getuserdetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("ManageMenu");

        }
    }
}
