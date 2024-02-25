using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Glamour_Estore.Models;

namespace Glamour_Estore.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult signup(SignUp s) 
        {
            SignUpRepository sr = new SignUpRepository();
            sr.AddSignUpInfo(s);

            return View();
        }
    }
}
