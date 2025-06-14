using Microsoft.AspNetCore.Mvc;
using dockerize_aspNetCore_jwt_api.Models;
using dockerize_aspNetCore_jwt_api.Services;
using dockerize_aspNetCore_jwt_api.Helpers;

namespace dockerize_aspNetCore_jwt_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(UserService userService, IConfiguration config) : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(User user)
    {
        if (!userService.Register(user))
            return BadRequest("User already exists.");
        return Ok("User registered.");
    }

    [HttpPost("login")]
    public IActionResult Login(User user)
    {
        var found = userService.Authenticate(user.Username, user.Password);
        if (found == null) return Unauthorized("Invalid credentials.");

        var token = JwtHelper.GenerateToken(user.Username, config["Jwt:Key"]!);
        return Ok(new { token });
    }
}
