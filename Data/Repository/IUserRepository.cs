using Data.Entities;

namespace Data.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User? Get(string username);
        void AddUser(User newUser);
        void DeleteUser(string username);
    }
}
