using System;
using Microsoft.AspNetCore.Mvc;
using Test_App.answers.entities;
using Test_App.answers.repository;
using Test_App.answers.RequestDto;
using Test_App.question.repository;
using Test_App.user.Repository;

namespace Test_App.answers.service
{
    public class AnswerService
    {
        private readonly AnswerRepository _answerRepository;
        private readonly UserRepository _userRepository;
        private readonly QuestionRepository _questionRepository;
        private readonly CommentRepository _commentRepository;
        public AnswerService(AnswerRepository answerRepository, UserRepository userRepository, QuestionRepository questionRepository, CommentRepository commentRepository)
        {
            _answerRepository = answerRepository;
            _userRepository = userRepository;
            _questionRepository = questionRepository;
            _commentRepository = commentRepository;
        }

        public Answer AddAnswer(AnswerRequestDto answerRequestDto)
        {
            var user = _userRepository.GetByUserId(answerRequestDto.AuthorId);
            var question = _questionRepository.GetById(answerRequestDto.QuestionId);
            if (user != null && question != null)
            {
                var answer = new Answer()
                {
                    Content = answerRequestDto.Content,
                    Author = user,
                    Question = question,
                    CreatedOn = DateTime.Now

                };
                return _answerRepository.Save(answer);
            }

            return null;
        }
        
        

        public Answer AddComment(CommentDto commentDto)
        {
            var user = _userRepository.GetByUserId(commentDto.UserId);
            var answer = _answerRepository.GetByAnswerId(commentDto.AnswerId);
            

            answer.Comments.Add(new Comment()
            {
                CommentText = commentDto.CommentText,
                CreatedTime = DateTime.Now,
                WrittenBy = user,
                Answer = answer
            });
            return answer;

        }
    }
}