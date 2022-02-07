using System;
using Test_App.user.entities;
using Test_App.user.Repository;
using Test_App.user.RequestDto;

namespace Test_App.user.service
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User AddUser(UserRequestDto userRequestDto)
        {
            Console.Write(userRequestDto);
            var user = new User()
            {
                Username = userRequestDto.Username,
                EmailId = userRequestDto.EmailId,
                FirstName = userRequestDto.FirstName,
                LastName = userRequestDto.LastName,
                Password = userRequestDto.Password,
                Description = userRequestDto.Description,
                AccountCreated = DateTime.Now
            };
           return  _userRepository.Save(user);
        }

        public User GetUserByUserName(string userName)
        {
            return _userRepository.GetByUserName(userName);
        }
    }
}