using Microsoft.AspNetCore.Mvc;

namespace EternaProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
