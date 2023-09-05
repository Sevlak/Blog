using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //returns all my posts
        {
            return View();
        }

        public IActionResult Post(int id) //returns an specific post
        {
            return View();
        }
    }
}
