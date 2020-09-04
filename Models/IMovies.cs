using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxApp.Models
{
    interface IMovies
    {
        IEnumerable<MoviesDB> GetAllMovies();
        MoviesDB GetSpecificMovie(int? id);
        MoviesDB AddMovie(MoviesDB movie);
    }
}
