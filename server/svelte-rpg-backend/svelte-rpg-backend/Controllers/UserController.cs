using Microsoft.AspNetCore.Mvc;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;

namespace svelte_rpg_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private static List<User> _users = new List<User>();

    public UserController()
    {
        
    }

    [HttpGet("{username}")]
    public ActionResult<User> GetByUsername(string username)
    {
        return _users.FirstOrDefault(e => e.UserName == username);
    }
    [HttpPost]
    public ActionResult<User> Add([FromForm] UserDTO user)
    {
        User createdUser = new User()
        {
            UserName = user.UserName,
            created_at = DateTime.Now,
            heroes = new List<Hero>(),
            updated_at = DateTime.Now,
            Email = user.Email,
            Password = user.Password
        };
        _users.Add(createdUser);
        return CreatedAtAction(nameof(GetByUsername), new { username = createdUser.UserName }, createdUser);
    }
}