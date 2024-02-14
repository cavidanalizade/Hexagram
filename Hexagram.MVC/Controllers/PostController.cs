using Microsoft.AspNetCore.Mvc;

namespace Hexagram.MVC.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
