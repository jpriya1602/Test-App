using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test_App.user.RequestDto;
using Test_App.user.responedto;
using Test_App.user.service;

namespace Test_App.user.controller
{
    [ApiController]
    [Route("/[controller]")]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }
        
        [HttpPost]
        public IActionResult Post(UserRequestDto userRequestDto)
        {
             var userResponseDto = _userService.AddUser(userRequestDto);
             if (userResponseDto is null)
             {
                 return NotFound();
             }
             return Ok(userResponseDto);
        }

        [HttpGet("{username}")]
        public IActionResult Get(string username)
        {
            var user = _userService.GetUserByUserName(username);
            if (user is null)
                return NotFound();
            return Ok(user);
        }
        
    }
}