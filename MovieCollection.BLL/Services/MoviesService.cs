using MovieCollection.BLL.Interfaces;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Services
{
    public class MoviesService : IMoviesService
    {
        public Task<Movie> Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll(int pageNr, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
