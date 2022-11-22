using Microsoft.EntityFrameworkCore;
using MovieCollection.DAL.Configurations;
using MovieCollection.DAL.Models;
using MovieCollection.DAL.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MovieCollection.DAL.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //base.OnModelCreating(modelBuilder);            
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new DirectorConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.Entity<Country>().Seed();
            modelBuilder.Entity<Director>().Seed();
            modelBuilder.Entity<Genre>().Seed();
            modelBuilder.Entity<User>().Seed();
        }
    }
}
