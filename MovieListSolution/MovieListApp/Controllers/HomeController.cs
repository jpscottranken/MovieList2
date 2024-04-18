using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieListApp.Models;

namespace MovieListApp.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext? context { get; set; }

        //  Constructor
        public HomeController(MovieContext ctx) => context = ctx;
        //{
        //    context = ctx;
        //}


        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre)
                                       .OrderBy(m => m.Name)
                                       .ToList();
            return View(movies);
        }
    }
}
