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
    public class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.ToTable("tblDirectors", "Director")
                    .HasKey(p => p.Id);
            builder.HasIndex(p => p.Id)
                    .IsUnique();

            builder.Property(p => p.Id)
                   .HasColumnType("int");

            builder.Property(p => p.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(25)");

            builder.Property(p => p.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(25)");

            builder.Property(p => p.DateOfBirth)
                    .IsRequired()
                    .HasColumnType("date");

            builder.Property(p => p.Nationality)
                    .IsRequired()
                    .HasColumnType("varchar(25)");

            builder.Property(p => p.IsActive)
                    .IsRequired()
                    .HasColumnType("varchar(25)");

            builder.Property(p => p.PicturePath)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
        }
    }
}
