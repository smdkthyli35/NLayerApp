using Microsoft.AspNetCore.Mvc;

namespace NLayer.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
