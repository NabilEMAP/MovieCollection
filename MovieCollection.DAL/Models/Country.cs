using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieCollection.DAL.Models
{
    [Table("Countries")]
    public class Country
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public Movie Movie { get; set; }
    }
}
