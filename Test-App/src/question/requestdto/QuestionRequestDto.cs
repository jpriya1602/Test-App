using System;
using System.ComponentModel.DataAnnotations;
using Test_App.user.entities;

namespace Test_App.question.RequestDto
{
    public class QuestionRequestDto
    {
        [Required]
        public string QuestionPosted { get; set; }
        
        [Required] 
        public string PostedBy { get; set; }
    }
}