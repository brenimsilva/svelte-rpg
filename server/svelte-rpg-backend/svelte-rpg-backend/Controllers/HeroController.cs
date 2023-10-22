using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Models.DTO.Response;
using svelte_rpg_backend.Services;

namespace svelte_rpg_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class HeroController : ControllerBase
{
    private HeroService _service;
    public HeroController(HeroService service)
    {
        this._service = service;
    }
    
    [HttpGet("{heroId}")]
    public async Task<IActionResult> GetById(int heroId)
    {
        try
        {
            var hero = await _service.GetById(heroId);
            return Ok(hero);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create(HeroDTO heroDto)
    {
        try
        {
            Hero hero = await _service.Create(heroDto); 
            return CreatedAtAction(nameof(GetById), new { heroId = hero.ActorId }, hero);
        }
        catch(Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPatch]
    public async Task<Hero> UpdateHero(int heroId, JsonPatchDocument<Hero> heroPatch)
    {
        Hero hero = await _service.UpdateHero(heroId, heroPatch); 
        return hero;
    }

    [HttpDelete]
    public async Task<int> Delete(int Id)
    {
        await _service.Delete(Id);
        return Id;
    }
}
