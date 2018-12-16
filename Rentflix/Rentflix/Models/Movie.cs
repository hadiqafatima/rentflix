using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rentflix.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime ReleaseData { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}