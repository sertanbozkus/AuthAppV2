using AuthAppV2.Context;
using AuthAppV2.Dtos;
using AuthAppV2.Models;
using AuthAppV2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAppV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

        // Authentication & Authorization
        // Kimlik Belirleme & Yetkilendirme
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost]
        public IActionResult Register(RegisterRequest request)
        {
            var userDto = new UserAddDto
            {
                Email = request.Email.Trim(),
                Password = request.Password
            };

           var result  =  _userService.AddUser(userDto);

            if (result.IsSucceed)
                return Ok(result.Message);
            else
                return Ok(result.Message);

        }

    }
}
