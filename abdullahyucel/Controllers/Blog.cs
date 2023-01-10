using Microsoft.AspNetCore.Mvc;

namespace abdullahyucel.Controllers
{
    public class Blog : Controller
    {
        public IActionResult BlogIndex()
        {
            return View();
        }
        public IActionResult Newton()
        {
            return View();
        }

        public IActionResult MailKit()
        {
            return View();
        }
    }
}
