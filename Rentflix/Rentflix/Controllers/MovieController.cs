using Rentflix.Models;
using Rentflix.ViewModels;
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
            var movies = db.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var movie = db.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        public ActionResult New()
        {
            var genres = db.Genres.ToList();
            var viewModelMovie = new MovieFormViewModel(new Movie())
            {   
                Genres = genres
            };
            return View("MovieForm", viewModelMovie);

        }
        public ActionResult Edit(int id)
        {
            var movie = db.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            var viewModel = new MovieFormViewModel(movie)
            {
                
                Genres = db.Genres.ToList()
            };
            return View("MovieForm", viewModel);
        }
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    
                    Genres = db.Genres.ToList()
                };
                return View("MovieForm", viewModel);
            }
            if (movie.Id == 0)
            {
                db.Movies.Add(movie);
            }
            else
            {
                var movieInDb = db.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;

            }

            db.SaveChanges();
            return RedirectToAction("Index", "Movie");
        }
    }
}