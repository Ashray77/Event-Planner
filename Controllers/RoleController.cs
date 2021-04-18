using EventPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventPlanner.Controllers
{
    public class RoleController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RoleController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult RoleRecord()
        {
            var displaydata = _db.RoleTable.ToList();
            return View(displaydata);
        }

        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleModel roleModel)
        {
            if (ModelState.IsValid)
            {
                _db.Add(roleModel);
                await _db.SaveChangesAsync();
                return RedirectToAction("RoleRecord");

            }
            return View(roleModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("RoleRecord");
            }
            var getroledetails = await _db.RoleTable.FindAsync(id);
            return View(getroledetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoleModel roleModel)
        {
            if (ModelState.IsValid)
            {
                _db.Update(roleModel);
                await _db.SaveChangesAsync();
                return RedirectToAction("RoleRecord");
            }
            return View(roleModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("RoleRecord");
            }
            var getroledetails = await _db.RoleTable.FindAsync(id);
            return View(getroledetails);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("RoleRecord");
            }
            var getroledetails = await _db.RoleTable.FindAsync(id);
            return View(getroledetails);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getroledetails = await _db.RoleTable.FindAsync(id);
            _db.RoleTable.Remove(getroledetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("RoleRecord");

        }
    }
}
