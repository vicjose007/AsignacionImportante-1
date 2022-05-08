using Microsoft.EntityFrameworkCore;
using MovieSolvex.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSolvex.Infrastructure
{
   public class MovieDbContext: DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) 
        {


        }

        public DbSet<Movie> Movies { get; set; }
    }
}
