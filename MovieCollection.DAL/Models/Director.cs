using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieCollection.DAL.Models
{
    [Table("Directors")]
    public class Director
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [StringLength(25)]
        [Required]        
        public string FirstName { get; set; }

        [StringLength(25)]
        [Required]
        public string LastName { get; set; }

        //[Column("DateOfBirth", TypeName = "date")]
        [Column]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [StringLength(25)]
        [Required]
        public string Nationality { get; set; }

        //[Column("IsActive", TypeName = "tinyint(1)")]
        [Column]
        [Required]
        public bool IsActive { get; set; }

        [StringLength(255)]
        public string PicturePath { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
