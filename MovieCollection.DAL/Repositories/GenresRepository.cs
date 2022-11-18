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
        private readonly ApplicationDbContext context;

        public GenresRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Genre> GetGenreByName(string name)
        {
            return await context.Genres.Where(x => x.Name == name).FirstOrDefaultAsync();
        }
    }
}
