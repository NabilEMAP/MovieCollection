using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly ICountriesRepository _countriesRepository;
        //private readonly IDirectorsRepository _directorsRepository;
        private readonly IGenresRepository _genresRepository;
        //private readonly IMoviesRepository _moviesRepository;
        //private readonly IUsersRepository _usersRepository;

        public UnitOfWork(
            ApplicationDbContext context,
            ICountriesRepository countriesRepository,
            //IDirectorsRepository directorsRepository,
            //IMoviesRepository moviesRepository,
            //IUsersRepository usersRepository,
            IGenresRepository genresRepository
            )
        {
            _context = context;
            _countriesRepository = countriesRepository;
            //_directorsRepository = directorsRepository;
            //_moviesRepository = moviesRepository;
            //_usersRepository = usersRepository;
            _genresRepository = genresRepository;
        }
        public ICountriesRepository CountriesRepository { get { return _countriesRepository; } }
        //public IDirectorsRepository DirectorsRepository { get { return _directorsRepository; } }
        //public IMoviesRepository MoviesRepository { get { return _moviesRepository; } }
        //public IUsersRepository UsersRepository { get { return _usersRepository; } }
        public IGenresRepository GenresRepository { get { return _genresRepository; } }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

    }
}
