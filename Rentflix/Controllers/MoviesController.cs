using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rentflix.Models;

namespace Rentflix.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }
	}
}