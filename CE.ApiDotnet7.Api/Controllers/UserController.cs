using CE.ApiDotnet7.Application.DTOs;
using CE.ApiDotnet7.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CE.ApiDotnet7.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
                
        }
 
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserDTO userDTO)
        {
            var result = await _userService.CreateAsync(userDTO);
            if(result.IsSuccess)
                return Ok(result);

            return BadRequest();
        }
        

    }
}
