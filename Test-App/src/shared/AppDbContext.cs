using Microsoft.EntityFrameworkCore;
using Test_App.question.entities;
using Test_App.user.entities;

namespace Test_App.shared
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}