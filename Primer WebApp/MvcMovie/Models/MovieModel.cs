using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}