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
        public Task<IEnumerable<UserDetailDTO>> GetAll();
        public Task<UserDetailDTO> GetById(int id);
        public Task<UserDetailDTO> Add(CreateUserDTO user);
        public Task<UserDetailDTO> Update(int id, UpdateUserDTO user);
        public Task<int> Delete(int id);
        
    }
}
