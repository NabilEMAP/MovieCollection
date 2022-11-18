using MovieCollection.BLL.Exceptions;
using MovieCollection.BLL.Interfaces;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using MovieCollection.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUnitOfWork uow;
        public UsersService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public async Task<User> Add(User user)
        {
            var _user = await uow.UsersRepository.GetByIdAsync(user.Id);
            if (_user == null)
                throw new RelationNotFoundException("the user was not found");

            uow.UsersRepository.AddAsync(user);
            uow.Commit();
            return user;
        }

        public async Task Delete(int id)
        {
            var user = await uow.UsersRepository.GetByIdAsync(id);
            if (user == null)
                throw new KeyNotFoundException("the user was not found");

            uow.UsersRepository.Remove(user);
            uow.Commit();
        }

        public IEnumerable<User> GetAll(int pageNr, int pageSize)
        {
            return null; //uow.UsersRepository.GetAll(pageNr, pageSize);
        }

        public IEnumerable<User> GetAll()
        {
            return null; // uow.UsersRepository.GetAllAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await uow.UsersRepository.GetByIdAsync(id);
        }

        public async Task<User> Update(User user)
        {
            var existing = await uow.UsersRepository.GetByIdAsync(user.Id);
            if (existing == null)
                throw new KeyNotFoundException("the user was not found");

            existing.FirstName = user.FirstName;
            existing.LastName = user.LastName;
            existing.Email = user.Email;
            existing.IsActive = user.IsActive;            
            uow.Commit();
            return existing;
        }
    }
}
