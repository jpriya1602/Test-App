using System.Linq;
using Test_App.shared;
using Test_App.user.entities;

namespace Test_App.user.Repository
{
    public class UserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User Save(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User GetByUserName(string username)
        {
            return _context.Users.FirstOrDefault(x => x.Username == username);
        }
    }
}