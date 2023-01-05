using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Repositories;
using MovieCollection.DAL.UOW;
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
            services.RegisterUnitOfWork();
            return services;
        }
        public static IServiceCollection RegisterDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlServer("name=ConnectionStrings:MovieCollection"));
            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICountriesRepository, CountriesRepository>();
            services.AddScoped<IGenresRepository, GenresRepository>();
            services.AddScoped<IDirectorsRepository, DirectorsRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IMoviesRepository, MoviesRepository>();
            return services;
        }

        public static IServiceCollection RegisterUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
