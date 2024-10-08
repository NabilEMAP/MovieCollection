﻿using Microsoft.EntityFrameworkCore;
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

            builder.Property(p => p.ReleaseDate)
                    .IsRequired()
                    .HasColumnType("date");

            builder.HasOne(p => p.Director)
                    .WithMany()
                    .HasForeignKey(p => p.DirectorId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Country)
                    .WithMany()
                    .HasForeignKey(p => p.CountryId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Genre)
                    .WithMany()
                    .HasForeignKey(p => p.GenreId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.DirectorId)
                    .HasColumnType("int");

            builder.Property(p => p.CountryId)
                    .HasColumnType("int");

            builder.Property(p => p.GenreId)
                    .HasColumnType("int");
        }
    }
}
