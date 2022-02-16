using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies.Api.Model;

namespace Movies.Api.Data
{
    public class MoviesApiContext : DbContext
    {
        public MoviesApiContext (DbContextOptions<MoviesApiContext> options)
            : base(options)
        {
        }

        public DbSet<Movies.Api.Model.Movie> Movie { get; set; }
    }
}
