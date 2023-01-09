using MovieCollection.Common.DTO.Countries;
using MovieCollection.Common.DTO.Directors;
using MovieCollection.Common.DTO.Genres;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.Common.DTO.Movies
{
    public class MovieDetailDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int DirectorId { get; set; }
        public DirectorDetailDTO Director { get; set; }
        public int CountryId { get; set; }
        public CountryDTO Country { get; set; }
        public int GenreId { get; set; }
        public GenreDTO Genre { get; set; }
        //public IEnumerable<GenreDTO> Genres { get; set; }
    }
}
