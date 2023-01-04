using MovieCollection.Common.DTO.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.Common.DTO.Directors
{
    public class UpdateDirectorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string IsActive { get; set; }
        public string PicturePath { get; set; }
        //public IEnumerable<MovieDetailDTO> Movies { get; set; }
    }
}
