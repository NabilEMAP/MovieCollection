using Microsoft.EntityFrameworkCore;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Repositories
{
    public class MoviesRepository : GenericRepository<Movie>, IMoviesRepository
    {
        private readonly ApplicationDbContext context;

        public MoviesRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Movie GetByTitle(string title)
        {
            return context.Movies.FirstOrDefault(s => s.Title == title);
        }
    }
}
