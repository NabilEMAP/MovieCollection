using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Repositories
{
    public interface IUsersRepository : IGenericRepository<User>
    {
        Task<User> GetByLastName(string lastName);
        Task<User> GetByFirstName(string firstName);
    }
}
