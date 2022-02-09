using Microsoft.AspNetCore.Mvc;
using Test_App.answers.entities;
using Test_App.answers.RequestDto;
using Test_App.answers.service;

namespace Test_App.answers.controller
{
    
    [Route("/[controller]")]
    [ApiController]
    public class AnswerController
    {
        private readonly AnswerService _answerService;

        public AnswerController(AnswerService answerService)
        {
            _answerService = answerService;
        }

        [HttpPost]
        public ActionResult<Answer> Post(AnswerRequestDto answerRequestDto)
        {
           return _answerService.AddAnswer(answerRequestDto);
        }

        [HttpPut]
        public ActionResult<Answer> PostComment(CommentDto commentDto)
        {
            return _answerService.AddComment(commentDto);
        }
        
    }
}