using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Glamour_Estore.Models;

namespace Glamour_Estore.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(login l)
        {
            loginRepository l2 = new loginRepository();
            string uname = l2.CheckLogIn(l);
            if (uname != null)
            {
                HttpContext.Response.Cookies.Append("UserLoggedIn",uname );
                // ab append ki hai to bar bar over add hoti jaiye ghi to hum ek check lgaiye gaey 
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");


        }
    }
}
