using Hexagram.Business.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hexagram.MVC.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreatePostVM vm)
        {
            return View();
        }

    }
}
