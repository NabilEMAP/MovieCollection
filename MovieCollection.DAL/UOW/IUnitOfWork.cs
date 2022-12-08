using MovieCollection.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.UOW
{
    public interface IUnitOfWork
    {
        //public ICountriesRepository CountriesRepository { get; }
        //public IDirectorsRepository DirectorsRepository { get; }
        public IGenresRepository GenresRepository { get; }
        //public IMoviesRepository MoviesRepository { get; }
        //public IUsersRepository UsersRepository { get; }
        Task Save();
    }
}
