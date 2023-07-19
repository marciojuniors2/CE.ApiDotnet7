using CE.ApiDotnet7.Api.Authentication;
using CE.ApiDotnet7.Application.DTOs;
using CE.ApiDotnet7.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CE.ApiDotnet7.Application.Services;

namespace CE.ApiDotnet7.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;

        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Post(UserAuthenticationDTO userAuthenticationDTO)
        {
            var result = await _userService.AuthenticateAsync(userAuthenticationDTO);
            if (result.IsSuccess)
            {
                var token = TokenService.GenerateToken(new UserDTO());
                return Ok(token);
            }


            return Unauthorized();
        }
    }
}
