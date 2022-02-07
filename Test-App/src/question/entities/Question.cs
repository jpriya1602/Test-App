using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Test_App.user.entities;

namespace Test_App.question.entities
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  Id { get; set; }

        public string QuestionPosted { get; set; }

        public DateTime PostedTime { get; set; }
        
        [Required] 
        public User PostedBy { get; set; }
    }
}