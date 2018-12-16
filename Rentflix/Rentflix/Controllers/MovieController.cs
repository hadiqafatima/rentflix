using Rentflix.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rentflix.Controllers
{
    public class MovieController : Controller
    {
        ApplicationDbContext db;
        public MovieController()
        {
            db = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
        // GET: Movie
        public ActionResult Index()
        {
            var movies = db.Movies.Include(m=>m.Genre).ToList();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var movie = db.Movies.Include(m => m.Genre).SingleOrDefault(m=>m.Id==id);
            if(movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }  
    }
}