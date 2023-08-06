using Library.API.Identity;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public AuthController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterUser user)
        {
            if (!ModelState.IsValid) BadRequest();

            var userToReturn = await _userServices.RegistertUserAsync(user);

            return Ok(userToReturn);
        }

    }
}
