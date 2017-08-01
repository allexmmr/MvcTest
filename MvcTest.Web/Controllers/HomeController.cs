using Microsoft.AspNetCore.Mvc;

namespace MvcTest.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}