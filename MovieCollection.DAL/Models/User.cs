using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieCollection.DAL.Models
{
    [Table("Users")]
    public class User
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

        [StringLength(100)]
        [Required]
        public string Email { get; set; }

        //[Column("IsActive", TypeName = "tinyint(1)")]
        //DefaultValue
        [Column]
        public bool IsActive { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
