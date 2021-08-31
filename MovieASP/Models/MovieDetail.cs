using Dal.Entities;
using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieASP.Models
{
    public class MovieDetail
    {
        private IMovieRepository _movieRepo;
        private IPersonRepository _personRepo;

        public MovieDetail(IMovieRepository mr, IPersonRepository pr)
        {
            _movieRepo = mr;
            _personRepo = pr;
        }

        public MovieDetail()
        {

        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public int ReleaseYear { get; set; }
        public Person Realisator { get {
                return _personRepo is null ? null : _personRepo.GetRealistorByMovieId(Id);
            } }
        public Person Scenarist { get {
                return _personRepo is null ? null : _personRepo.GetScenaristByMovieId(Id);
            } }

        public IEnumerable<ActorView> Casting {
            get
            {
                return _movieRepo is null ? null : _movieRepo.GetCastingByMovieId(Id).Select(a => new ActorView
                {
                    Role = a.Role,
                    FirstName = _personRepo.GetById(a.PersonId).FirstName,
                    LastName = _personRepo.GetById(a.PersonId).LastName
                }) ;
            }
            set { Casting = value; }
        }
    }
}
