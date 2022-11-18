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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("tblUsers", "User")
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

            builder.HasIndex(p => p.Email)
                    .IsUnique();

            builder.Property(p => p.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

            builder.Property(p => p.IsActive)
                    .HasColumnType("tinyint(1)");
        }
    }
}
