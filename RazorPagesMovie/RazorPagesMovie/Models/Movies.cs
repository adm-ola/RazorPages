using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }


        public class RazorPagesMovieContext : DbContext
        {
            public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options)
                : base(options)
            {
            }

            public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
        }


    }

}
