using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxApp.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AjaxApp.Models
{
    public class MoviesDB
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // to generate an ID
        public string IdMovies { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public RatingMovie? RateMovie { get; set;}

        public int? Price { get; set; }
        
        public DateTime? ReleaseDate { get; set; }

        public string MainCharacter { get; set; }

        public string DirectedBy { get; set; }
    }
}
