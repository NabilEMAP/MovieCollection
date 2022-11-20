using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieCollection.DAL.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public Movie Movie { get; set; }
    }
}
