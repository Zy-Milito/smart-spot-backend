using Data.Entities;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User? Get(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }

        public void AddUser(User newUser)
        {
            _context.Users.Add(newUser);
        }

        public void DeleteUser(string username)
        {
            _context.Users.Single(u => u.Username == username).Status = Models.StatusEnum.Deleted;
        }
    }
}
