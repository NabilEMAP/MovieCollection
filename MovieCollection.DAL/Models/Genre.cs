﻿using System;

namespace MovieCollection.DAL.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }

    }
}
