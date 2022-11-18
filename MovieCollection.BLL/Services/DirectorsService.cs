using MovieCollection.BLL.Interfaces;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Services
{
    public class DirectorsService : IDirectorsService
    {
        public Task<Director> Add(Director director)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Director> GetAll(int pageNr, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Director> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Director> Update(Director director)
        {
            throw new NotImplementedException();
        }
    }
}
