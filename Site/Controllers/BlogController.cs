using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Site.Domain;
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

        [Route("/")]
        [Route("Blog")]
        [Route("Blog/Index")]
        public IActionResult Index() //returns all my posts
        {
            using (var context = new PostContext())
            {
                //TODO(will): we have a problem here. we are sending the domain objects, not the view models.
                var model = context.Posts.AsNoTracking().ToList(); //as we are using for reading only, we don't need to track the entities
                return View(model);
            }
        }

        [Route("Blog/Post/{id}")]
        public IActionResult Post(int id) //returns an specific post
        {
            return View();
        }

        [HttpGet]
        [Route("Blog/Post/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("Blog/Post/Create")]
        public IActionResult Create(PostViewModel post)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Create");
        }
    }
}
