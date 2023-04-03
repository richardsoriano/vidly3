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
            //var movies = _context.Movies;
            var movies = GetMovies();
            return View(movies);
        }
        public IActionResult Details(int id)
        {
            //var movies = _context.Movies.SingleOrDefault(c => c.Id == id);
            //return View(movies);
            return View();
        }
        public IActionResult Edit(int id) { return Content("id=" + id); }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie
                {
                    Id = 1,
                    Name="Shrek 2"
                },
                new Movie
                {
                    Id = 2,
                    Name="Scream 5"
                },
                new Movie
                {
                    Id = 3,
                    Name ="Pinocchio"
                }
            };
        }

    }
}
