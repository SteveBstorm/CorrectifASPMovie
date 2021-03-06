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
        private ICommentRepository _commentRepo;

        public MovieDetail(IMovieRepository mr, IPersonRepository pr, ICommentRepository cr)
        {
            _movieRepo = mr;
            _personRepo = pr;
            _commentRepo = cr;
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

        public IEnumerable<Comment> Commentaires
        {
            get
            {
                return _commentRepo is null ? null : _commentRepo.GetByMovieId(Id);
            }
        }
    }
}
