using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chefbabyyoda.Models;
using Microsoft.AspNetCore.Http;

namespace chefbabyyoda.Controllers
{ 
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("plates") == null)
            {
                HttpContext.Session.SetInt32("plates", 0);
            }
            int? plate = HttpContext.Session.GetInt32("plates");
            plate++;
            HttpContext.Session.SetInt32("plates", (int) plate);
            ViewBag.plates = plate;
            ViewBag.plates = HttpContext.Session.GetInt32("plates");
            Menu random = new Menu();
            //Console.WriteLine(random.Value);
            return View(random);
        }

        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }


    }
}
