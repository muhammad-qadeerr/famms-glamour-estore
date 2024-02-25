using Glamour_Estore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Glamour_Estore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        { 
        
            string data = "";
            if (HttpContext.Request.Cookies.ContainsKey("UserLoggedIn"))
            {

                string user = Request.Cookies["UserLoggedIn"];
                data = $" {user} is logged in ";
                return View("Index",data);
     
            }
            return View("Index",data);
        }

        [HttpPost]
        public IActionResult Index(string email , string password)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
