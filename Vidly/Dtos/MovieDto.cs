﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public DateTime DateAdded { get; set; }

        [Range(0, 20)]
        public byte NumberInStock { get; set; }
        
        public int GenreId { get; set; }

        public GenreDto Genre { get; set; }
    }
}