using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public Answer GetByAnswerId(int id)
        {
            var answer = _context.Answers.Include(x => x.Comments)
                .FirstOrDefault(x => x.Id == id);
            return answer;
        }
    }
}