using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamour_Estore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult about()
        {
            return View();
        }
    }
}
