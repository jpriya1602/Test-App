using System;
using Microsoft.AspNetCore.Mvc;
using Test_App.question.entities;
using Test_App.question.RequestDto;
using Test_App.question.service;
using Test_App.user.service;

namespace Test_App.question.controller
{
    [Route("/[controller]")]
    [ApiController]
    public class QuestionController
    {
        private readonly QuestionService _questionService;
       
        public QuestionController(QuestionService questionService)
        {
           _questionService = questionService;
        }

        [HttpPost]
        public ActionResult<Question> Post(QuestionRequestDto questionRequestDto)
        {
            
               var question =  _questionService.AddQuestion(questionRequestDto);
               if (question is null)
               {
                   return new BadRequestResult();
               }

               return question;
        }
    }
}