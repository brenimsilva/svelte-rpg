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
    private async Task<ICollection<ActorAttribute>> _CalcAttributes(Actor actor)
    {
        Dictionary<AttributeEnum, double> attributeDictionary = new Dictionary<AttributeEnum, double>()
        {
            {AttributeEnum.Attack,0}, {AttributeEnum.Defense,0}, {AttributeEnum.Evasion,0},
            {AttributeEnum.CritChance,0}, {AttributeEnum.CritDamage,0}, {AttributeEnum.HealthPoints,0},
            {AttributeEnum.MaxHealthPoints,0}
        };
        foreach (var stat in actor.Stats)
        {
            IEnumerable<AttributeStatsRatio> listRatioPerStat = _context.AttributeStatRatio.Where(e => e.StatId == stat.StatId);
            foreach (var statRatio in listRatioPerStat)
            {
                double value = (stat.Value * actor.Tier) * statRatio.Ratio;
                attributeDictionary[(AttributeEnum)statRatio.AttributeId] += value;
            }
        }
        foreach (var attribute in actor.Attributes)
        {
            attribute.Value = attributeDictionary[(AttributeEnum)attribute.AttributeId];
        }
        
        return actor.Attributes;
    }
    public async Task<ICollection<ActorAttribute>> UpdateActorAttributes(Actor actor)
    {
        ICollection<ActorAttribute> actorAttributes = await _CalcAttributes(actor);
        await _context.ActorAttribute.AddRangeAsync(actorAttributes);
        return actorAttributes;
    }

}