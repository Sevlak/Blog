using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Site.Models;

namespace Site.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }

        [Route("Blog")]
        [Route("Blog/Index")]
        public IActionResult Index() //returns all my posts
        {
            using (var context = new PostContext())
            {
                var model = context.Posts.AsNoTracking().ToList(); //as we are using for reading only, we don't need to track the entities
                return View(model);
            }
        }

        [Route("Blog/Post/{id}")]
        public IActionResult Post(int id) //returns an specific post
        {
            return View();
        }
    }
}
