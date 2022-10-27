using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazerPageMovie.Models;

namespace RazerPageMovie.Data
{
    public class RazerPageMovieContext : DbContext
    {
        public RazerPageMovieContext (DbContextOptions<RazerPageMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazerPageMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
