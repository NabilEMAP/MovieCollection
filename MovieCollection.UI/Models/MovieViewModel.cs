﻿using MovieCollection.DAL.Models;

namespace MovieCollection.UI.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int DirectorId { get; set; }
        public DirectorViewModel Director { get; set; }
        public int CountryId { get; set; }
        public CountryViewModel Country { get; set; }
    }
}
