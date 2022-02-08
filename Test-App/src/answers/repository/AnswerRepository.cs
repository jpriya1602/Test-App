using Test_App.answers.entities;
using Test_App.shared;

namespace Test_App.answers.repository
{
    public class AnswerRepository
    {
        private readonly AppDbContext _context;
        public AnswerRepository(AppDbContext context)
        {
            _context = context;
        }

        public Answer Save(Answer answer)
        {
             _context.Answers.Add(answer);
             _context.SaveChanges();
             return answer;
        }
    }
}