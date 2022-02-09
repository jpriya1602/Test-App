using System.ComponentModel.DataAnnotations;

namespace Test_App.answers.RequestDto
{
    public class CommentDto
    {
        [Required]
        public string CommentText { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        [Required]
        public int AnswerId { get; set; }
    }
}