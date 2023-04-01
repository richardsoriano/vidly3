using Microsoft.AspNetCore.Mvc;
using vidly3.Models;

namespace vidly3.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customers = GetCustomers().SingleOrDefault(c => c.Id == id);
            return View(customers);
        }
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer { Id = 1, Name ="Gary" },
                new Customer { Id = 2, Name="Az Heelzs"}
            };
        }
    }
}

