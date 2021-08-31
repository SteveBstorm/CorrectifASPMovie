using Dal.Entities;
using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieASP.Models
{
    public class CastingForm
    {
        private IMovieRepository _movieRepo;
        private IPersonRepository _personRepo;

        public CastingForm(IMovieRepository mr, IPersonRepository pr)
        {
            _movieRepo = mr;
            _personRepo = pr;
        }

        public CastingForm()
        {

        }

        public int MovieId { get; set; }

        public IEnumerable<Movie> Movies { get {
                return _movieRepo is null ? null : _movieRepo.GetAll();
            } }

        public int PersonId { get; set; }

        public IEnumerable<Person> Persons
        {
            get
            {
                return _personRepo is null ? null : _personRepo.GetAll();
            }
        }

        public string Role { get; set; }

    }
}
