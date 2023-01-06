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
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("tblGenres", "Genre")
                    .HasKey(p => p.Id);
            builder.HasIndex(p => p.Id)
                    .IsUnique();

            builder.Property(p => p.Id)
                   .HasColumnType("int");

            builder.HasIndex(p => p.Name)
                    .IsUnique();

            builder.Property(p => p.Name)
                    .IsRequired()
                    .HasColumnType("varchar(25)");


        }
    }
}
