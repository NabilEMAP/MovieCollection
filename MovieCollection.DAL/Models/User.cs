using System;

namespace MovieCollection.DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IsActive { get; set; }
        //public IEnumerable<Movie> Movies { get; set; }
    }
}
