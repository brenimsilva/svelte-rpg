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
    RpgContext _ctx;
    
    public AuthController(RpgContext ctx) {
        this._ctx = ctx;
    }

    [HttpPost]
    public async Task<IActionResult> LogIn([FromForm] string usuario, [FromForm] string senha)
    {
        string senhaCrypto = Util.StringUtilities.Hash(senha);
        User u = await _ctx.User.FirstOrDefaultAsync(e => e.UserName == usuario && e.Password == senhaCrypto);

        if(u == null) {
            return BadRequest();
        }

        return Ok(u);
        
    }
}
