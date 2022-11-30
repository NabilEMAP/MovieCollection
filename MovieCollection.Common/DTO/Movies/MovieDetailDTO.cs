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
        public Director Director { get; set; }
        //public ICollection<User> Users { get; set; }
        //public ICollection<Genre> Genres { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
