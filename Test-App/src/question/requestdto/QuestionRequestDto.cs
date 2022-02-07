using System;
using System.ComponentModel.DataAnnotations;
using Test_App.user.entities;

namespace Test_App.question.RequestDto
{
    public class QuestionRequestDto
    {
        public DateTime PostedTime { get; set; }
        
        [Required]
        public string QuestionPosted { get; set; }
        
        [Required] 
        public User PostedBy { get; set; }
    }
}