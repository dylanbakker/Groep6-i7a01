using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sprint9.Models;

namespace Sprint9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult About(string firstName)
        {
            return Content($"Welkom bij SoundSharp {firstName}");
        }

        /* public IActionResult Error()
         {
             return View(new User { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
         }*/
    }
}
