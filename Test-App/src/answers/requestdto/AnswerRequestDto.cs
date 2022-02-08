using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Test_App.answers.entities;
using Test_App.user.entities;

namespace Test_App.answers.RequestDto
{
    public class AnswerRequestDto
    {
        [Required]
        public string Content { get; set; }
        public int  QuestionId { get; set; }
        public int AuthorId { get; set; }
    }
}