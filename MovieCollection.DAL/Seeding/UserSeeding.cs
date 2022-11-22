using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Seeding
{
    public static class UserSeeding
    {
        public static void Seed(this EntityTypeBuilder<User> modelBuilder)
        {
            modelBuilder.HasData(
                new User() { Id = 1, FirstName = "Nabil", LastName = "El Moussaoui", Email = "Nabil_EM@outlook.com", IsActive = "Yes" },
                new User() { Id = 2, FirstName = "Abdelmajid", LastName = "Amiri", Email = "Abdelmajid.Amiri@outlook.com", IsActive = "Yes" },
                new User() { Id = 3, FirstName = "Azdine", LastName = "El Jattari", Email = "Azdine.ElJattari@outlook.com", IsActive = "No" },
                new User() { Id = 4, FirstName = "Mohamed", LastName = "Azdad", Email = "Mohamed.Azdad@outlook.com", IsActive = "Yes" },
                new User() { Id = 5, FirstName = "Mirwahaj", LastName = "Waez", Email = "Mirwahaj.Waez@outlook.com", IsActive = "No" }
            );
        }
    }
}
