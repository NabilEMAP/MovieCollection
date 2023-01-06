using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("tblMovies", "Movie")
                    .HasKey(p => p.Id);
            builder.HasIndex(p => p.Id)
                    .IsUnique();

            builder.Property(p => p.Id)
                   .HasColumnType("int");

            builder.HasIndex(p => p.Title)
                    .IsUnique();

            builder.Property(p => p.Title)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

            builder.HasIndex(p => p.ReleaseDate)
                    .IsUnique();

            builder.Property(p => p.ReleaseDate)
                    .IsRequired()
                    .HasColumnType("date");

            builder.Property(p => p.DirectorId)
                    .HasColumnType("int");

            builder.Property(p => p.CountryId)
                    .HasColumnType("int");
        }
    }
}
