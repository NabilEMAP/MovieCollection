using Microsoft.EntityFrameworkCore;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Repositories
{
    public class MoviesRepository : GenericRepository<Movie>, IMoviesRepository
    {
        public MoviesRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies
                .Include(c => c.Country)
                .Include(d => d.Director)
                .Include(g => g.Genre)
                .ToListAsync();
        }

        public async Task<Movie> GetByTitle(string title)
        {
            return await _context.Movies.Where(s => s.Title == title).FirstOrDefaultAsync();
        }

        //public async Task<Movie> GetByCountry(Country country)
        //{
        //    return await _context.Movies.Where(s => s.Country == country).FirstOrDefaultAsync();
        //}

        //public async Task<Movie> GetByGenre(IEnumerable<Genre> genres)
        //{
        //    return await _context.Movies.Where(s => s.Genres == genres).FirstOrDefaultAsync();
        //}

        //public async Task<Movie> GetByDirector(Director director)
        //{
        //    return await _context.Movies.Where(s => s.Director == director).FirstOrDefaultAsync();
        //}
    }
}
