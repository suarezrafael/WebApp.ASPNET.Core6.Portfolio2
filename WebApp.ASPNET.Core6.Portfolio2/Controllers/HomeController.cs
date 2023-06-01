using Microsoft.AspNetCore.Mvc;

namespace WebApp.ASPNET.Core6.Portfolio2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
