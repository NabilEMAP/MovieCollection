using MovieCollection.Common.DTO.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.Common.DTO.Users
{
    public class CreateUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IsActive { get; set; }
        //public IEnumerable<MovieDetailDTO> Movies { get; set; }
    }
}
