using Microsoft.EntityFrameworkCore;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Models.Enums;
using Attribute = svelte_rpg_backend.Models.Attribute;

namespace svelte_rpg_backend.Services;

public class GameLogicService : IGameLogicService
{
    private RpgContext _context;
    public GameLogicService(RpgContext context)
    {
        this._context = context;
    }
    public async Task<List<ActorAttribute>> CalcAttributes(Actor actor)
    {
        List<ActorAttribute> attributeList = new List<ActorAttribute>();
        
        foreach (var stat in actor.Stats)
        {
            AttributeStatsRatio ratio = await _context.AttributeStatRatio.Include(e => e.Attributes)
                .Include(e => e.Stats).FirstOrDefaultAsync(e => e.StatId == stat.StatId);
            
            double value = (stat.Value * actor.Tier) * ratio.Ratio;
            ActorAttribute actorAttribute = new ActorAttribute((AttributeEnum)ratio.AttributeId, actor.Id, value);
            attributeList.Add(actorAttribute);
        }
        
        return attributeList;
    }

}