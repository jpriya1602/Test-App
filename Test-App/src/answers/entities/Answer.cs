using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Test_App.question.entities;
using Test_App.user.entities;

namespace Test_App.answers.entities
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int Id { get; set; }
        
        [Required]
        public string Content { get; set; }
        
        [Required]
        public Question Question { get; set; }
        
        [Required]
        public User Author { get; set; }
        
        public DateTime CreatedOn { get; set; }
        
        public DateTime EditedOn { get; set; }
        
        public List<User> LikedUsers { get; set; }
        
        public List<User> DislikedUsers { get; set; }

        public List<User> ViewedUsers { get; set; }
        
        public List<Comment> Comments { get; set; }

    }
}