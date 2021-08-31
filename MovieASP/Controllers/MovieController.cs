using Dal.Entities;
using Dal.Interface;
using Microsoft.AspNetCore.Mvc;
using MovieASP.Models;
using MovieASP.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieASP.Controllers
{
    public class MovieController : Controller
    {
        private IMovieRepository _movieRepo;
        private IPersonRepository _personRepo;
        public MovieController(IMovieRepository mr, IPersonRepository pr)
        {
            _movieRepo = mr;
            _personRepo = pr;
        }

        public IActionResult Index()
        {
            return View(_movieRepo.GetAll());
        }
        [AuthRequired]
        public IActionResult Detail(int Id)
        {
            Movie movieFromDb = _movieRepo.GetById(Id);
            MovieDetail movieDetail = new MovieDetail(_movieRepo, _personRepo);
            movieDetail.Id = movieFromDb.Id;
            movieDetail.Title = movieFromDb.Title;
            movieDetail.Synopsis = movieFromDb.Synopsis;
            movieDetail.ReleaseYear = movieFromDb.ReleaseYear;
            return View(movieDetail);
        }
        [AdminRequired]
        public IActionResult Create()
        {
            return View(new MovieForm(_personRepo));
        }
        [AdminRequired]
        [HttpPost]
        public IActionResult Create(MovieForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            _movieRepo.Create(form.ToDal());
            return RedirectToAction("Index", "Movie");
        }
        [AdminRequired]
        public IActionResult AddActor()
        {
            return View(new CastingForm(_movieRepo, _personRepo));
        }
        [AdminRequired]
        [HttpPost]
        public IActionResult AddActor(CastingForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            _personRepo.SetRole(form.MovieId, form.PersonId, form.Role);
            return RedirectToAction("Index", "Movie");
        }
    }
}
