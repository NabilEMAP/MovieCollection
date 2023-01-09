using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Seeding
{
    public static class MovieSeeding
    {
        public static void Seed(this EntityTypeBuilder<Movie> modelBuilder)
        {
            modelBuilder.HasData(
                new Movie() 
                { 
                    Id = 1,
                    Title = "Bad Boys 2",
                    ReleaseDate = new DateTime(2003, 10, 8),
                    DirectorId = 1,
                    CountryId = 187, //United States of America
                    GenreId = 1
                },
                new Movie()
                {
                    Id = 2,
                    Title = "Tenet",
                    ReleaseDate = new DateTime(2020, 8, 26),
                    DirectorId = 2,
                    CountryId = 186, //United Kingdom
                    GenreId = 1
                },
                new Movie()
                {
                    Id = 3,
                    Title = "Aliens",
                    ReleaseDate = new DateTime(1979, 9, 13),
                    DirectorId = 3,
                    CountryId = 186,
                    GenreId = 10
                },
                new Movie()
                {
                    Id = 4,
                    Title = "Midnight in Paris",
                    ReleaseDate = new DateTime(2011, 6, 15),
                    DirectorId = 4,
                    CountryId = 187,
                    GenreId = 6
                },
                new Movie()
                {
                    Id = 5,
                    Title = "King Kong",
                    ReleaseDate = new DateTime(2005, 12, 14),
                    DirectorId = 5,
                    CountryId = 124, //New Zealand
                    GenreId = 1
                }
            );
        }
    }
}
