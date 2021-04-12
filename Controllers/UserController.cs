using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace EventPlanner.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult UserRecord()
        {
            var displaydataUser = _db.UserTable.ToList();
            return View(displaydataUser);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserAccount usra)
        {
            if (ModelState.IsValid)
            {
                _db.Add(usra);
                await _db.SaveChangesAsync();
                return RedirectToAction("Login","Home");

            }
            return View(usra);
        }
        
    }
}
