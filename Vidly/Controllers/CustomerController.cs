using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>{
                new Customer { id = 1, Name = "John Smith"},
                new Customer { id = 2, Name = "Mary Williams"}
            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customers = new List<Customer>{
                new Customer { id = 1, Name = "John Smith"},
                new Customer { id = 2, Name = "Mary Williams"}
            };


            var viewModel = new CustomerViewModel
            {
                Customers = (from n in customers
                            where n.id == id
                            select n).ToList()
            };

            return View(viewModel);
        }
    }
}