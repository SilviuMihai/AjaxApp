using AjaxApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxApp.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace AjaxApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<MoviesDB> GetAllMovies { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public RatingMovie? RateMovie { get; set; }

        [Required]
        public int? Price { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public string MainCharacter { get; set; }

        [Required]
        public string DirectedBy { get; set; }
    }
}
