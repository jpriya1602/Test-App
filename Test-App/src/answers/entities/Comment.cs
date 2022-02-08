using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Test_App.user.entities;

namespace Test_App.answers.entities
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string CommentText { get; set; }
        
        public User WrittenBy { get; set; }
        
        public Answer Answer { get; set; }
        
        public DateTime CreatedTime { get; set; }
    }
}