﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace MovieCollection.DAL.Models
{
    [Table("Movies")]
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Genre> Genres { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

    }
}
