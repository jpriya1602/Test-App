using System.Dynamic;
using Test_App.shared;
using Test_App.user.entities;
using Test_App.user.RequestDto;

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
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}