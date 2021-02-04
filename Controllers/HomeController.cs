using Joel_Hilton_Film_Collection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Joel_Hilton_Film_Collection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movies model)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddMovie(model);
                return View("Confirmation", model);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Collection()
        {
            return View(TempStorage.Films);
        }

        public IActionResult Podcast()
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
