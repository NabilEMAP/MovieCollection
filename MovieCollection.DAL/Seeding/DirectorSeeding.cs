using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Seeding
{
    public static class DirectorSeeding
    {
        public static void Seed(this EntityTypeBuilder<Director> modelBuilder)
        {
            modelBuilder.HasData(
                new Director() { Id = 1, FirstName = "Michael", LastName = "Bay", DateOfBirth = new DateTime(1965, 2, 17), Nationality = "American", IsActive = "Yes", PicturePath = "/images/MichaelBay.png"},
                new Director() { Id = 2, FirstName = "Christopher", LastName = "Nolan", DateOfBirth = new DateTime(1970, 7, 30), Nationality = "English", IsActive = "Yes", PicturePath = "/images/ChristopherNolan.png" },
                new Director() { Id = 3, FirstName = "Ridley", LastName = "Scott", DateOfBirth = new DateTime(1937, 11, 30), Nationality = "English", IsActive = "Yes", PicturePath = "/images/RidleyScott.png" },
                new Director() { Id = 4, FirstName = "Woody", LastName = "Allen", DateOfBirth = new DateTime(1935, 12, 1), Nationality = "American", IsActive = "No", PicturePath = "/images/WoodyAllen.png" },
                new Director() { Id = 5, FirstName = "Peter", LastName = "Jackson", DateOfBirth = new DateTime(1961, 10, 31), Nationality = "New Zealander", IsActive = "Yes", PicturePath = "/images/PeterJackson.png" }
            );
        }
    }
}
