using Dal.Entities;
using System.Collections.Generic;

namespace Dal.Interface
{
    public interface IMovieRepository
    {
        void Create(Movie m);
        IEnumerable<Movie> GetAll();
        Movie GetById(int Id);
        IEnumerable<Casting> GetCastingByMovieId(int MovieId);
    }
}