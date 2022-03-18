using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UniqueServices.Models;

namespace UniqueServices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // return the views
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult EmailSent()
        {
            return View();
        }

        public IActionResult AirConditioning()
        {
            return View();
        }

        public IActionResult Heating()
        {
            return View();
        }

        public IActionResult Plumbing()
        {
            return View();
        }
        public IActionResult AirConditioningRepair()
        {
            return View();
        }
        public IActionResult Electrical()
        {
            return View();
        }
        public IActionResult AirDuctCleaning()
        {
            return View();
        }
        public IActionResult IndoorAirQuality()
        {
            return View();
        }
        public IActionResult Offers()
        {
            return View();
        }
        public IActionResult ProsClub()
        {
            return View();
        }
        public IActionResult ServicePlans()
        {
            return View();
        }
        public IActionResult ScheduleService()
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