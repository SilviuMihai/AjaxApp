using AjaxApp.Models;
using AjaxApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxApp.Controllers
{
    public class HomeController: Controller
    {
        private readonly IMovies _movies;
        public HomeController(IMovies movies)
        {
            _movies = movies;
        }
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Index(HomeViewModel model)
        {
            if (ModelState.IsValid)
            {
                MoviesDB addmovieDB = new MoviesDB()
                {
                    Title = model.Title,
                    Genre = model.Genre,
                    RateMovie = model.RateMovie,
                    Price = model.Price,
                    ReleaseDate = model.ReleaseDate,
                    MainCharacter = model.MainCharacter,
                    DirectedBy = model.DirectedBy
                };
                _movies.AddMovie(addmovieDB);
                return View(model);
            }
            return View();
        }
    }
}
