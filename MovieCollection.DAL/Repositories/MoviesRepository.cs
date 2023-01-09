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
            //Query
            string query = $"SELECT *  FROM [MovieCollection].[Movie].[tblMovies] m  WHERE m.Title like '%{title}%'";
            return await _context.Movies.FromSqlRaw(query).FirstAsync();
        }
    }
}
