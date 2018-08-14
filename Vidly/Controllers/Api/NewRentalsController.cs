using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRentals)
        {
            var customer = _context.Customers.Single(c => c.Id == newRentals.CustomerId);
            var movies = _context.Movies.Where(m => newRentals.MovieIds.Contains(m.Id)).Select(m => m);

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    BadRequest("Movie is not available.");
                }

                movie.NumberAvailable--;
                var rental = new Rental
                {
                    Movie = movie,
                    Customer = customer,
                    DateRented = DateTime.Now,
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();
            return Ok();
        }
    }
}
