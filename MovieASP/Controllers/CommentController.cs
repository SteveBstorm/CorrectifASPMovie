using Dal.Entities;
using Dal.Interface;
using Microsoft.AspNetCore.Mvc;
using MovieASP.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieASP.Controllers
{
    public class CommentController : Controller
    {
        private ICommentRepository _commentRepo;

        public CommentController(ICommentRepository cr)
        {
            _commentRepo = cr;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddComment(int Id)
        {

            
            return View();
        }

        [HttpPost]
        public IActionResult AddComment(Comment form)
        {
            form.UserId = HttpContext.Session.GetUser().Id;
            _commentRepo.Create(form);
            return RedirectToAction("Detail", "Movie", new { id = form.MovieId });
        }
    }
}
