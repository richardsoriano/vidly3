using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using vidly3.Data;
using vidly3.Models;
using vidly3.ViewModels;

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
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel { 
                MembershipTypes = membershipTypes 
            };
            return View("CustomerForm",viewModel);
        }
        public IActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
        };
            return View("CustomerForm", viewModel);
        }
        
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c=> c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.IsSubscribedToNewsletter= customer.IsSubscribedToNewsletter;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.Birthdate= customer.Birthdate;
                TryUpdateModelAsync(customerInDb);
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
        public ActionResult Details(int id)
        {
            var customers =_context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);
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

