using Microsoft.AspNetCore.Mvc;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Services;
namespace svelte_rpg_backend.Controllers;

[ApiController]
[Route("[controller]")]

public class BattleController: ControllerBase
{
    private BattleService _service;

    public BattleController(BattleService service) {
        this._service = service;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id) {
        return Ok();
    }
}
