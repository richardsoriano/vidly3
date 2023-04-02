using Microsoft.AspNetCore.Mvc;
using vidly3.Data;
using vidly3.Models;
using vidly3.ViewModels;

namespace vidly3.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        public IActionResult Random()
        {
          
        var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name="Customer 1" },
                new Customer { Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel); 
        }
        public IActionResult Index()
        {
            var movies = _context.Movies;
            return View(movies);
        }
        public IActionResult Details(int id)
        {
            var movies = _context.Movies.SingleOrDefault(c => c.Id == id);
            return View(movies);
        }
        public IActionResult Edit(int id) { return Content("id=" + id); }
       

    }
}
