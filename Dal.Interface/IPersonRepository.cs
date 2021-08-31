using Dal.Entities;
using System.Collections.Generic;

namespace Dal.Interface
{
    public interface IPersonRepository
    {
        void Create(Person p);
        IEnumerable<Person> GetAll();
        Person GetById(int Id);
        Person GetRealistorByMovieId(int MovieId);
        Person GetScenaristByMovieId(int MovieId);
        void SetRole(int MovieId, int PersonId, string Role);
    }
}