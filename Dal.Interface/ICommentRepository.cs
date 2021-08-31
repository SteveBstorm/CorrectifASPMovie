using Dal.Entities;
using System.Collections.Generic;

namespace Dal.Interface
{
    public interface ICommentRepository
    {
        void Create(Comment c);
        void Delete(int Id);
        IEnumerable<Comment> GetByMovieId(int MovieId);
    }
}