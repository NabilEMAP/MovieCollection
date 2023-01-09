using MovieCollection.Common.DTO.Genres;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.Common.DTO.Movies
{
    public class CreateMovieDTO
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int DirectorId { get; set; }
        //public Director Director { get; set; }
        public int CountryId { get; set; }
        //public Country Country { get; set; }
        public int GenreId { get; set; }
        //public Genre Genre { get; set; }
        //public IEnumerable<GenreDTO> Genres { get; set; }
    }
}
