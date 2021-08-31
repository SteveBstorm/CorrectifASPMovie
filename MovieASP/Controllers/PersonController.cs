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
    [AdminRequired]
    public class PersonController : Controller
    {
        private IPersonRepository _personRepo;
        public PersonController(IPersonRepository pr)
        {
            _personRepo = pr;
        }
        
        public IActionResult Index()
        {
            return View(_personRepo.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            _personRepo.Create(form.ToDal());
            return RedirectToAction("Index", "Movie");
        }
    }
}
