using Data.Entities;
using Data.Repository;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User? AuthenticateUser(string username, string password)
        {
            User? userToReturn = _userRepository.Get(username);
            if (userToReturn is not null && userToReturn.Password == password)
                return userToReturn;
            return null;
        }

        public void Delete(string username)
        {
            _userRepository.DeleteUser(username);
        }
    }
}
