using Microsoft.EntityFrameworkCore;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MovieCollection.DAL.Repositories
{
    public class GenresRepository : GenericRepository<Genre>, IGenresRepository
    {
        public GenresRepository(ApplicationDbContext context) : base(context)
        {
        }

        //public async Task<Genre> GetByMovies(IEnumerable<Movie> movies)
        //{
        //    return await _context.Genres.Where(s => s.Movies == movies).FirstOrDefaultAsync();
        //}

        public async Task<Genre> GetByIdAsync(int id)
        {
            return await _context.Genres.Where(genre => genre.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Genre> GetByName(string name)
        {
            return await _context.Genres.Where(x => x.Name == name).FirstOrDefaultAsync();
        }
    }
}
