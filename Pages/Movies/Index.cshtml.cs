using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazerPageMovie.Data;
using RazerPageMovie.Models;

namespace RazerPageMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazerPageMovie.Data.RazerPageMovieContext _context;

        public IndexModel(RazerPageMovie.Data.RazerPageMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
