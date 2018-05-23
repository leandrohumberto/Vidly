﻿using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public string FormTitle { get; set; }
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}