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
    
    [HttpPost]
    public async Task<ActionResult<Monster>> MonsterSpawn([FromForm] int tier)
    {
        Monster m = await _monsterService.MonsterSpawn(MonsterEnum.Rat, tier);
        return CreatedAtAction(nameof(GetById), new {id = m.Id}, m);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        Monster m = await _monsterService.GetById(id);
        return Ok(m);
    }
}