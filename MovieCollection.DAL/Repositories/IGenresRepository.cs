using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Repositories
{
    public interface IGenresRepository : IGenericRepository<Genre>
    {
        Task<Genre> GetByName(string name);
        Task<Genre> GetByIdAsync(int id);
        //Task<Genre> GetByMovies(IEnumerable<Movie> movies);
    }
}
