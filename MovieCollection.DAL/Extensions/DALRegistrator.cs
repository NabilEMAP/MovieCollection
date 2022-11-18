using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Repositories;
using MovieCollection.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Extensions
{
    public static class DALRegistrator
    {
        public static IServiceCollection RegisterInfrastructure(this IServiceCollection services)
        {
            services.RegisterDbContext();
            services.RegisterRepositories();
            return services;
        }
        public static IServiceCollection RegisterDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlServer("MovieCollection"));
            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICountriesRepository, CountriesRepository>();
            services.AddScoped<IDirectorsRepository, DirectorsRepository>();
            services.AddScoped<IGenresRepository, GenresRepository>();
            services.AddScoped<IMoviesRepository, MoviesRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            return services;
        }
    }
}
