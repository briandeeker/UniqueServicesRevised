using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UniqueServices.Models;
using UniqueServices.Services.Interfaces;
using UniqueServices.Services.Types;

namespace UniqueServices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailService _emailService;

        public HomeController(ILogger<HomeController> logger, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        // return the views
        public IActionResult Index()
        {
            EmailMessageViewModel vm = new EmailMessageViewModel() { RedirectUrl = "Index" };

            return View(vm);
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
        public IActionResult Careers()
        {
            return View();
        }
        public IActionResult StJude()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SendEmail(EmailMessageViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm.RedirectUrl, vm);
            }

            var messageToSend = new EmailMessage()
            {
                Name = vm.Name,
                EmailAddress = vm.EmailAddress,
                Phone = vm.Phone,
                Service = vm.Selection,
            };

            try
            {
                await _emailService.SendEmailAsync(messageToSend);

                return RedirectToAction("EmailSent");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}