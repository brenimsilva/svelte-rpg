using Microsoft.AspNetCore.Mvc;

namespace svelte_rpg_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class HeroController : ControllerBase
{
    private static List<string> _heroList = new List<string>();
    private readonly ILogger<HeroController> _logger;

    public HeroController(ILogger<HeroController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{id}")]
    public IEnumerable<string> GetHeroesByPlayerId(string id)
    {
        return _heroList;
        
    }
    
}