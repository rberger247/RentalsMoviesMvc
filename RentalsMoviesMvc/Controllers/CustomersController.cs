
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentalsMoviesMvc.Models;
using RentalsMoviesMvc.ViewModels;
using System.Data.Entity;
using Microsoft.AspNet.Identity;


namespace RentalsMoviesMvc.Controllers
{
    public class CustomersController : Controller
    {

       public  RentalStoreEntities dbContext;

        public CustomersController()
        {

            dbContext = new RentalStoreEntities();
        }  
        
        
        // GET: Customers
        public ViewResult Index()
        {
            return View("CustomerList");
        }
        public ViewResult CustomerList()
        {
           var customers = dbContext.Customers.ToList();
           return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = dbContext.Customers.Include(c => c.MembershipTypes).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }


        public ActionResult New()
        {
            var membershipTypes = dbContext.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customers(),
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "CanAddCustomers")]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customers customer)
        {
         
        
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = dbContext.MembershipTypes.ToList()
                };

                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
                dbContext.Customers.Add(customer);
            else
            {
                var customerInDb = dbContext.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                //customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }

           dbContext.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }



    }
}