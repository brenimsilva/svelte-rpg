using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Services;

namespace svelte_rpg_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private UserService _service;

    public UserController(UserService service)
    {
        _service = service;
    }

    // [HttpGet]
    // public async Task<IActionResult> GetByGuid([FromQuery]Guid guid)
    // {
    //     try
    //     {
    //         var user =  await _service.GetByGuid(guid);
    //         if (user != null)
    //         {
    //             return Ok(user);
    //         }
    //         return NoContent();
    //     } 
    //     catch (Exception e)
    //     {
    //         return StatusCode(500, $"UserController/GetByUsername => {e.Message}");
    //     }
    // }
    // [HttpPost]
    // public async Task<IActionResult> Add([FromForm] UserDTO user)
    // {
    //     try
    //     {
    //         User createdUser = await _service.Add(user);
    //         return CreatedAtAction(nameof(GetByGuid), new { guid = createdUser.UserGuid }, createdUser);
    //     }
    //     catch(Exception e)
    //     {
    //         return StatusCode(500, $"UserController/Add => {e.Message}");
    //     }
    // }

    // [HttpPatch("{username}")]
    // public async Task<IActionResult> UpdateUser(string username, [FromBody] JsonPatchDocument<User> userPatch)
    // {
    //     try
    //     {
    //         User user = await _service.UpdateUser(username, userPatch);
    //         return CreatedAtAction(nameof(GetByGuid), new { username = username }, user);
    //     }
    //     catch (Exception e)
    //     {
    //         return BadRequest();
    //     }
    // }
}