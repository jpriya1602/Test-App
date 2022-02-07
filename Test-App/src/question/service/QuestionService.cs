using System;
using Microsoft.AspNetCore.Mvc;
using Test_App.question.entities;
using Test_App.question.repository;
using Test_App.question.RequestDto;
using Test_App.user.Repository;

namespace Test_App.question.service
{
    public class QuestionService
    {
        private readonly QuestionRepository _questionRepository;
        private readonly UserRepository _userRepository;
        public QuestionService(QuestionRepository questionRepository, UserRepository userRepository)
        {
            _questionRepository = questionRepository;
            _userRepository = userRepository;
        }

        public Question AddQuestion(QuestionRequestDto questionRequestDto)
        {
            var user = _userRepository.GetByUserName(questionRequestDto.PostedBy);
            
            if (user != null && !string.IsNullOrEmpty(questionRequestDto.QuestionPosted))
            {
                var question = new Question()
                {
                    PostedBy = user,
                    QuestionPosted = questionRequestDto.QuestionPosted,
                    PostedTime = DateTime.Now

                };
                
                Console.WriteLine(question);
                return _questionRepository.Save(question);
            }

            return null;

        }
    }
}