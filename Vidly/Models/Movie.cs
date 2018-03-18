using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(0, byte.MaxValue)]
        public byte NumberInStock { get; set; }

        [Required]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}