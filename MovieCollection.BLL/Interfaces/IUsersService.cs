using MovieCollection.Common.DTO.Users;
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
        //public IEnumerable<User> GetAll(int pageNr, int pageSize);
        public Task<IEnumerable<UserDTO>> GetAll();
        public Task<UserDTO> GetById(int id);
        public Task<UserDTO> Add(CreateUserDTO user);
        public Task<UserDTO> Update(int id, UpdateUserDTO user);
        public Task<int> Delete(int id);
        
    }
}
