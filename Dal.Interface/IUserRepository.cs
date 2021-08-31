using Dal.Entities;
using System.Data;

namespace Dal.Interface
{
    public interface IUserRepository
    {
        User Login(string email, string password);
        void Register(User u);
    }
}