using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = _context.Movies.FirstOrDefault();
            var customers = _context.Customers.ToList();
            var viewModel = new RandomViewModel { Movie = movie, Customers = customers };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            return View(_context.Movies.Include(mbox => mbox.Genre).ToList());
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).Where(m => m.Id == id).FirstOrDefault();

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, byte month)
        {
            return Content($"{year}/{month}");
        }
    }
}