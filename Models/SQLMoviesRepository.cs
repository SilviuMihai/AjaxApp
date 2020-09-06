using AjaxApp.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxApp.Models
{
    public class SQLMoviesRepository : IMovies
    {
        private readonly AppDBContext _context;

        public SQLMoviesRepository(AppDBContext context)
        {
            _context = context;
        }

        public MoviesDB AddMovie(MoviesDB movie)
        {
            _context.MoviesConnectionDB.Add(movie);
            _context.SaveChanges();
            return movie;
        }

        public IEnumerable<MoviesDB> GetAllMovies()
        {
            return _context.MoviesConnectionDB;
        }

        public MoviesDB GetSpecificMovie(int? id)
        {
            return _context.MoviesConnectionDB.Find(id);        
        }
    }
}
