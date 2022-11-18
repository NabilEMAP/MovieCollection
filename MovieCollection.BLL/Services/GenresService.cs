using MovieCollection.BLL.Interfaces;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Services
{
    public class GenresService : IGenresService
    {
        public Task<Genre> Add(Genre genre)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetAll(int pageNr, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> Update(Genre genre)
        {
            throw new NotImplementedException();
        }
    }
}
