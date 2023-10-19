using Microsoft.AspNetCore.Mvc;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Services;
using Microsoft.EntityFrameworkCore;
using svelte_rpg_backend.Util;
using svelte_rpg_backend.Context;
namespace svelte_rpg_backend.Controllers;

[ApiController]
[Route("[controller]")]

public class AuthController : ControllerBase
{
    private AuthService _service;
    
    public AuthController(AuthService service) {
        this._service = service;
    }

    // [HttpPost]
    // public async Task<IActionResult> LogIn([FromForm] string usuario, [FromForm] string senha)
    // {
    //     try {
    //         var u = await _service.LogIn(usuario, senha);
    //
    //         return Ok(u);
    //     } catch(Exception ex) {
    //         return Unauthorized("Incorret User or Password"); 
    //     }
    // }
}
