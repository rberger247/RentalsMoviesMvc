using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using RentalsMoviesMvc.Dto;
using RentalsMoviesMvc.Models;

namespace RentalsMoviesMvc.Controllers.Api
{
    public class MoviesController : ApiController
    {



        private RentalStoreEntities _context;

        public MoviesController()
        {
            _context = new RentalStoreEntities();
        }

        public IEnumerable<MovieDto> GetMovies(string query = null)
        {
            var moviesQuery = _context.Movies
                .Include(m => m.Genres)
                .Where(m => m.NumberAvailable > 0);

            if (!String.IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery.Where(m => m.Name.Contains(query));

            return moviesQuery
                .ToList()
                .Select(Mapper.Map<Movies, MovieDto>);
        }











    }
}
