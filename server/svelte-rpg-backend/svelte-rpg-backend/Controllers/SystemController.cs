using Microsoft.AspNetCore.Mvc;
using svelte_rpg_backend.Services;
using Microsoft.AspNetCore.Http;
namespace svelte_rpg_backend.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class SystemController : ControllerBase
{
    
    private SystemService _systemService;
    public SystemController(SystemService systemService)
    {
        this._systemService = systemService;
    }

    [HttpPost]
    public async Task<IActionResult> DataBaseInit()
    {
        var h  = HttpContext.Request.Headers;
        var res = await _systemService.DataBaseInit();
        return Ok(res);
    }
}