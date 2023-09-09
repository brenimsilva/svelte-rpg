using System.Net;
using System.Text;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Util;

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
    public async Task<IActionResult> GetByUsername(string username)
    {
        try
        {
            var user = _users.FirstOrDefault(e => e.UserName == username);
            if (user != null)
            {
                return Ok(user);
            }
            return NoContent();
        } 
        catch (Exception e)
        {
            return StatusCode(500, $"UserController/GetByUsername => {e.Message}");
        }
    }
    [HttpPost]
    public async Task<IActionResult> Add([FromForm] UserDTO user)
    {
        try
        {
            string hash = StringUtilities.Hash(user.Password);
            User createdUser = new User()
            {
                UserName = user.UserName,
                created_at = DateTime.Now,
                heroes = new List<Hero>(),
                updated_at = DateTime.Now,
                Email = user.Email,
                Password = hash
            };
            _users.Add(createdUser);
            return CreatedAtAction(nameof(GetByUsername), new { username = createdUser.UserName }, createdUser);
        }
        catch(Exception e)
        {
            return StatusCode(500, $"UserController/Add => {e.Message}");
        }
    }

    [HttpPatch("{username}")]
    public async Task<IActionResult> UpdateUser(string username, [FromBody] JsonPatchDocument<User> userPatch)
    {
        try
        {
            var user = _users.FirstOrDefault(x => x.UserName == username);
            if (user != null)
            {
                userPatch.ApplyTo(user);
            }
            else
            {
                return NotFound();
            }
            return CreatedAtAction(nameof(GetByUsername), new { username = username }, user);
        }
        catch (Exception e)
        {
            return BadRequest();
        }
    }
}