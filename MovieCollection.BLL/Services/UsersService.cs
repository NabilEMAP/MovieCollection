//using AutoMapper;
//using MovieCollection.BLL.DTO.Users;
//using MovieCollection.BLL.Exceptions;
//using MovieCollection.BLL.Interfaces;
//using MovieCollection.Common.DTO.Users;
//using MovieCollection.DAL.Contexts;
//using MovieCollection.DAL.Models;
//using MovieCollection.DAL.UOW;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MovieCollection.BLL.Services
//{
//    public class UsersService : IUsersService
//    {
//        public readonly IUnitOfWork _uow;
//        public readonly IMapper _mapper;

//        public UsersService(IUnitOfWork uow, IMapper mapper)
//        {
//            _uow = uow;
//            _mapper = mapper;
//        }

//        public async Task<UserDTO> Add(CreateUserDTO entity)
//        {
//            var user = _mapper.Map<User>(entity);
//            await _uow.UsersRepository.Add(user);
//            await _uow.Save();
//            return _mapper.Map<UserDTO>(user);
//        }

//        public async Task<int> Delete(int id)
//        {
//            var toDeleteUser = await _uow.UsersRepository.GetByIdAsync(id);
//            if (toDeleteUser == null)
//            {
//                throw new KeyNotFoundException("This user does not exists");
//            }

//            _uow.UsersRepository.Delete(toDeleteUser);
//            _uow.Save();
//            return 0;
//        }

//        public async Task<IEnumerable<UserDTO>> GetAll()
//        {
//            var users = await _uow.UsersRepository.GetAllAsync();
//            return _mapper.Map<IEnumerable<UserDTO>>(users);
//        }

//        public async Task<UserDTO> GetById(int id)
//        {
//            var user = await _uow.UsersRepository.GetByIdAsync(id);
//            return _mapper.Map<UserDTO>(user);
//        }

//        public async Task<UserDTO> Update(int id, UpdateUserDTO entity)
//        {
//            var userFromRequest = _mapper.Map<User>(entity);
//            var userToUpdate = await _uow.UsersRepository.GetByIdAsync(id);

//            if (userToUpdate == null)
//            {
//                throw new KeyNotFoundException("This user does not exist");
//            }

//            userToUpdate.FirstName = userFromRequest.FirstName;
//            userToUpdate.LastName = userFromRequest.LastName;
//            userToUpdate.Email = userFromRequest.Email;
//            userToUpdate.IsActive = userFromRequest.IsActive;

//            await _uow.UsersRepository.Update(userToUpdate);
//            await _uow.Save();
//            return _mapper.Map<UserDTO>(userToUpdate);
//        }
//    }
//}
