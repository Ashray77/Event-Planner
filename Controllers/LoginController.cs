using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventPlanner.Models;
using Microsoft.AspNetCore.Identity;




namespace EventPlanner.Controllers
{
    public class LoginController : Controller
    {

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public LoginController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            
        }

        //private readonly ApplicationDbContext _db;
        //public LoginController(ApplicationDbContext db)
        //{
        //    _db = db;
        //}


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Register()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserAccount userAccount)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName=userAccount.Email, Email = userAccount.Email };
                var result = await userManager.CreateAsync(user, userAccount.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Login", "Login");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login log)
        {
            if (ModelState.IsValid)
            {

                  var result = await signInManager.PasswordSignInAsync(log.Email, log.Password, log.RememberMe, false);

                if (result.Succeeded)
                {
                    
                    return RedirectToAction("Index", "Home");
                }
                
                ModelState.AddModelError(string.Empty,"Invallid UserName or Password");
                
            }
            return View(log);
        }
    }
}
