using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiz.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext db;
        // GET: User
        public UserController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            List<Quiz.Models.User> users = db.Users.ToList();
            return View(users);
        }
    }
}