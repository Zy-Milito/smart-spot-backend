using Data.Entities;

namespace Services
{
    public interface IUserService
    {
        List<User> GetAll();
        User? AuthenticateUser(string username, string password);
        void Delete(string username);
    }
}
