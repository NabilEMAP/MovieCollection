using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieCollection.DAL.Models
{
    [Table("Genres")]
    public class Genre
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [StringLength(25)]
        [Required]
        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
