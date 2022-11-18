using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Interfaces
{
    public interface IUsersService
    {
        public IEnumerable<User> GetAll(int pageNr, int pageSize);
        public IEnumerable<User> GetAll();
        public Task<User> GetById(int id);
        public Task<User> Add(User user);
        public Task Delete(int id);
        public Task<User> Update(User user);
    }
}
