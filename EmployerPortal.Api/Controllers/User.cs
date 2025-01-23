using EmployerPortal.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployerPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet(Name = "{username}")]
        public async Task<IActionResult> GetUser(string? username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return BadRequest("Username can't be empty");
            }

            var user = await _userService.GetUserByUsernameAssync(username);

            if (user == null)
            {
                return NotFound("User not found.");
            }

            return Ok($"Hello {user.Name}");
        }
    }
}
