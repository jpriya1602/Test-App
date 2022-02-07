using Test_App.question.entities;
using Test_App.shared;

namespace Test_App.question.repository
{
    public class QuestionRepository
    {
        private readonly AppDbContext _context;
        public QuestionRepository(AppDbContext context)
        {
            _context = context;
        }

        public Question Save(Question question)
        {
            _context.Add(question);
            _context.SaveChanges();
            return question;
        }
    }
}