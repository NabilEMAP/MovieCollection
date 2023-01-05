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
    public class UsersRepository : GenericRepository<User>, IUsersRepository
    {
        public UsersRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<User> OrderByLastName(string lastName)
        {
            return await _context.Users.OrderBy(x => x.LastName == lastName).FirstOrDefaultAsync();
        }

        public async Task<User> OrderByFirstName(string firstName)
        {
            return await _context.Users.OrderBy(x => x.FirstName == firstName).FirstOrDefaultAsync();
        }

        public async Task<User> GetByLastName(string lastName)
        {
            return await _context.Users.Where(x => x.LastName == lastName).FirstOrDefaultAsync();
        }

        public async Task<User> GetByFirstName(string firstName)
        {
            return await _context.Users.Where(x => x.FirstName == firstName).FirstOrDefaultAsync();
        }
    }
}
