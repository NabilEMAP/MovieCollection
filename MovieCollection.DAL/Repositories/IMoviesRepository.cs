using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Repositories
{
    public interface IMoviesRepository : IGenericRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetByTitle(string title);
        //Task<Movie> GetByCountry(Country country);
        //Task<Movie> GetByGenre(IEnumerable<Genre> genres);
        //Task<Movie> GetByDirector(Director director);
    }
}
