using System;

namespace Test_App.user.responedto
{
    public class UserResponseDto
    {
        public string Username { get; set; }

        public string EmailId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Description { get; set; }

        public string Password { get; set; }
        
        public DateTime AccountCreated { get; set; }
    }
}