using abdullahyucel.Models;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;
using System.Diagnostics;

namespace abdullahyucel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailService emailService;

        public HomeController(
            ILogger<HomeController> logger,
            IEmailService emailService
            )
        {
            _logger = logger;
            this.emailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactUsViewModel model)
        {
            emailService.Send("abdullahyucelcom@gmail.com", $"abdullahyucel.com---Konu:{model.Subject}", $"{model.Subject}\n---{model.Name}\n---{model.Email}\n---{model.Message}", true);
            TempData["messageSent"]= true;
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }
        
        public IActionResult Services()
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