using MovieCollection.Common.DTO.Movies;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.DTO.Users
{
    public class UserDetailDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IsActive { get; set; }
        //public IEnumerable<MovieDetailDTO> Movies { get; set; }
    }
}
