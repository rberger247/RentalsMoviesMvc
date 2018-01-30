using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentalsMoviesMvc.Models;

namespace RentalsMoviesMvc.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }
        public byte GenreId { get; set; }
      
        public string Name { get; set; }

        public System.DateTime ReleaseDate { get; set; }
        public System.DateTime DateAdded { get; set; }
        public byte? NumberInStock { get; set; }
        public byte? NumberAvailable { get; set; }

        public GenreDto genres { get; set; }
    }
}