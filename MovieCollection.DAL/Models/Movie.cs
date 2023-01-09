using System;

namespace MovieCollection.DAL.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        //public ICollection<Genre> Genres { get; set; }

    }
}
