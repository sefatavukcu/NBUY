using Erp2_Ders.Models;
using Erp2_Ders.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Erp2_Ders.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SendGridEmailService _emailService;

        public HomeController(ILogger<HomeController> logger, SendGridEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            var emailService = new EmailService();
            emailService.Send("mesut@wissen", "Test Mesajı", "Konu");
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