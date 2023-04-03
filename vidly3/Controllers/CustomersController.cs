using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vidly3.Data;
using vidly3.Models;

namespace vidly3.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext  _context;
        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public IActionResult Index()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();
            return View(customers);
        }
        public IActionResult New()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            var customers =_context.Customers.SingleOrDefault(c => c.Id == id);
            return View(customers);
        }
        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>()
        //    {
        //        new Customer { Id = 1, Name ="Gary" },
        //        new Customer { Id = 2, Name="Az Heelzs"}
        //    };
        //}
    }
}

