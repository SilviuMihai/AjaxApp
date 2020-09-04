using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxApp.Models
{
    public class SQLMoviesRepository : IMovies
    {
        public MoviesDB AddMovie(MoviesDB movie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MoviesDB> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public MoviesDB GetSpecificMovie(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
