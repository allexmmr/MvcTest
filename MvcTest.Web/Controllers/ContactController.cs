using Microsoft.AspNetCore.Mvc;

namespace MvcTest.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}