using Test_App.answers.entities;
using Test_App.answers.RequestDto;
using Test_App.shared;

namespace Test_App.answers.repository
{
    public class CommentRepository
    {
        private readonly AppDbContext _appDbContext;

        public CommentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Comment Save(Comment comment)
        {
            _appDbContext.Comments.Add(comment);
            _appDbContext.SaveChanges();
            return comment;
        }
    }
}