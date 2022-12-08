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

        public async Task<Genre> GetGenreByIdAsync(int id)
        {
            return await _context.Genres.FirstOrDefaultAsync(genre => genre.Id == id);
        }

        public async Task<Genre> GetGenreByName(string name)
        {
            return await _context.Genres.Where(x => x.Name == name).FirstOrDefaultAsync();
        }



    }
}
