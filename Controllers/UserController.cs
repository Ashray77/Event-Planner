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

        //get-default
        public IActionResult Register()
        {
            //List<RoleModel> RoleList = new List<RoleModel>();
            //RoleList = (from roletype in _db.RoleTable select roletype).ToList();
            //RoleList.Insert(0, new RoleModel { role_id = 0, role = "Choose Your Role" });
            //ViewBag.listofrole = RoleList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserAccount usra)
        {
            if (ModelState.IsValid)
            {
                _db.Add(usra);
                await _db.SaveChangesAsync();
                return RedirectToAction("Login","Login");

            }
            return View(usra);
        }

            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return RedirectToAction("UserRecord");
                }
                var getuserdetails = await _db.UserTable.FindAsync(id);
                return View(getuserdetails);

            }

            [HttpPost]
            public async Task<IActionResult> Edit(UserAccount useracc)
            {
                if (ModelState.IsValid)
                {
                    _db.Update(useracc);
                    await _db.SaveChangesAsync();
                    return RedirectToAction("UserRecord");
                }
                return View(useracc);
            }

            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                return RedirectToAction("UserRecord");
            }
            var getuserdetails = await _db.UserTable.FindAsync(id);
            return View(getuserdetails);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("UserRecord");
            }
            var getuserdetails = await _db.UserTable.FindAsync(id);
            return View(getuserdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getuserdetails = await _db.UserTable.FindAsync(id);
            _db.UserTable.Remove(getuserdetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("UserRecord");

        }
    }
}
