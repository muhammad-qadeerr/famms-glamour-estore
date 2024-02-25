using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamour_Estore.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult blog()
        {
            return View();
        }
    }
}
