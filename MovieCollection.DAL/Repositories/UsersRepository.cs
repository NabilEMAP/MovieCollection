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
        private readonly ApplicationDbContext context;

        public UsersRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<User> GetByLastName(string lastName)
        {
            return await context.Users.Where(x => x.LastName == lastName).FirstOrDefaultAsync();
        }
    }
}
