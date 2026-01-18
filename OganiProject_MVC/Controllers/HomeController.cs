
using Microsoft.AspNetCore.Mvc;

namespace OganiProject_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
