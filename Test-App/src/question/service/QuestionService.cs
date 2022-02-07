using Test_App.question.entities;
using Test_App.question.repository;

namespace Test_App.question.service
{
    public class QuestionService
    {
        private readonly QuestionRepository _questionRepository;
        public QuestionService(QuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        
       
    }
}