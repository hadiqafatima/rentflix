using Rentflix.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rentflix.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public CustomerController()
        {
            db = new ApplicationDbContext();
        }
        
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = db.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = db.Customers.Include(c=> c.MembershipType).SingleOrDefault(c => c.Id == id);
            if(customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}