using Microsoft.AspNetCore.Mvc;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.Enums;
using svelte_rpg_backend.Services;

namespace svelte_rpg_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class MonsterController : ControllerBase
{
    private MonsterService _monsterService;

    public MonsterController(MonsterService service)
    {
        this._monsterService = service;
    }
    
    [HttpGet]
    public async Task<ActionResult<Monster>> MonsterSpawn()
    {
        Monster m = await _monsterService.MonsterSpawn(MonsterEnum.Rat, 1);
        return Ok(m);
    }
}