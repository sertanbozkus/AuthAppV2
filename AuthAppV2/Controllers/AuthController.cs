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


        [HttpPost("/register")]
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
                return BadRequest(result.Message);

        }

        [HttpPost("/Login")] // HttpGet yazarsam veriler querystring üzerinde taşınırken görülür. O nedenle bir ekleme yapmayacak  bile olsam login işlemlerinde HttpPost tercih ediyorum.
        public IActionResult Login(LoginRequest request)
        {

            var loginUserDto = new LoginUserDto
            {
                Email = request.Email.Trim(),
                Password = request.Password
            };

            var result = _userService.LoginUser(loginUserDto);

            if (!result.IsSucceed)
                return BadRequest(result.Message);

            var user = result.Data;

            // ASIL OLAY BAŞLIYOR !






            return Ok();

        }

    }
}
