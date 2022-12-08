using Microsoft.Extensions.DependencyInjection;
using MovieCollection.BLL.Interfaces;
using MovieCollection.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Extensions
{
    public static class ServiceRegistrator
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //services.AddScoped<ICountriesService, CountriesService>();
            //services.AddScoped<IDirectorsService, DirectorsService>();
            services.AddScoped<IGenresService, GenresService>();
            //services.AddScoped<IMoviesService, MoviesService>();
            //services.AddScoped<IUsersService, UsersService>();
            return services;
        }

        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
