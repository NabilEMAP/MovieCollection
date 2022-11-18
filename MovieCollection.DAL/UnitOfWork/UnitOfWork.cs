using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        private readonly ICountriesRepository countriesRepository;
        private readonly IDirectorsRepository directorsRepository;
        private readonly IGenresRepository genresRepository;
        private readonly IMoviesRepository moviesRepository;
        private readonly IUsersRepository usersRepository;

        public UnitOfWork(
            ApplicationDbContext context,
            ICountriesRepository countriesRepository,
            IDirectorsRepository directorsRepository,
            IGenresRepository genresRepository,
            IMoviesRepository moviesRepository,
            IUsersRepository usersRepository
            )
        {
            this.context = context;
            this.countriesRepository = countriesRepository;
            this.directorsRepository = directorsRepository;
            this.genresRepository = genresRepository;
            this.moviesRepository = moviesRepository;
            this.usersRepository = usersRepository;
        }

        public ICountriesRepository CountriesRepository => countriesRepository;
        public IDirectorsRepository DirectorsRepository => directorsRepository;
        public IGenresRepository GenresRepository => genresRepository;
        public IMoviesRepository MoviesRepository => moviesRepository;
        public IUsersRepository UsersRepository => usersRepository;

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
