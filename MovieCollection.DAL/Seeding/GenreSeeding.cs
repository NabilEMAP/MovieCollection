using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Seeding
{
    public static class GenreSeeding
    {
        public static void Seed(this EntityTypeBuilder<Genre> modelBuilder)
        {
            modelBuilder.HasData(
                new Genre() { Id = 1, Name = "Action" },
                new Genre() { Id = 2, Name = "Adventure" },
                new Genre() { Id = 3, Name = "Animation" },
                new Genre() { Id = 4, Name = "Comedy" },
                new Genre() { Id = 5, Name = "Devotional" },
                new Genre() { Id = 6, Name = "Drama" },
                new Genre() { Id = 7, Name = "Hindu mythology" },
                new Genre() { Id = 8, Name = "Historical" },
                new Genre() { Id = 9, Name = "Horror" },
                new Genre() { Id = 10, Name = "Science fiction" },
                new Genre() { Id = 11, Name = "Western" },
                new Genre() { Id = 12, Name = "Other" }
            );
        }
    }
}
