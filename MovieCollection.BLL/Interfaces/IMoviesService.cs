using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Interfaces
{
    public interface IMoviesService
    {
        public IEnumerable<Movie> GetAll(int pageNr, int pageSize);
        public Task<Movie> GetById(int id);
        public Task<Movie> Add(Movie movie);
        public Task Delete(int id);
        public Task<Movie> Update(Movie movie);
    }
}
