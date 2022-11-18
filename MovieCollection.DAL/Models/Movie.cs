using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace MovieCollection.DAL.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Title { get; set; }

        //[Column("ReleaseDate", TypeName = "date")]
        [Column]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("Director")]
        [Required]
        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Genre> Genres { get; set; }

        [ForeignKey("Country")]
        [Required]
        public int CountryId { get; set; }
        public Country Country { get; set; }

    }
}
