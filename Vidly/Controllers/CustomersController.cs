using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        readonly IList<Customer> _customers = new List<Customer>
        {
            new Customer{ Id = 1, Name = "John Smith" },
            new Customer{ Id = 2, Name = "Mary Williams" }
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(_customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            return View(customer);
        }
    }
}