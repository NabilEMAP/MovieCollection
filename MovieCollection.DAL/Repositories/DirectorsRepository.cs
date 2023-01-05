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
    public class DirectorsRepository : GenericRepository<Director>, IDirectorsRepository
    {
        public DirectorsRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Director> OrderByNationality(string nationality)
        {
            return await _context.Directors.OrderBy(s => s.Nationality == nationality).FirstOrDefaultAsync();
        }

        public async Task<Director> OrderByLastName(string lastName)
        {
            return await _context.Directors.OrderBy(s => s.LastName == lastName).FirstOrDefaultAsync();
        }

        public async Task<Director> OrderByFirstName(string firstName)
        {
            return await _context.Directors.OrderBy(s => s.FirstName == firstName).FirstOrDefaultAsync();
        }

        public async Task<Director> GetByNationality(string nationality)
        {
            return await _context.Directors.Where(s => s.Nationality == nationality).FirstOrDefaultAsync();
        }

        public async Task<Director> GetByLastName(string lastName)
        {
            return await _context.Directors.Where(s => s.LastName == lastName).FirstOrDefaultAsync();
        }

        public async Task<Director> GetByFirstName(string firstName)
        {
            return await _context.Directors.Where(s => s.FirstName == firstName).FirstOrDefaultAsync();
        }
    }
}
