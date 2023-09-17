using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Models.DTO.Response;

namespace svelte_rpg_backend.Services;

public class HeroService : IHeroService
{
    private RpgContext _context;
    private SystemService _systemService;
    private GameLogicService _gameLogicService;
    public HeroService(RpgContext ctx, SystemService systemService, GameLogicService glService)
    {
        this._context = ctx;
        this._systemService = systemService;
        this._gameLogicService = glService;
    }

    public async Task<HeroResponseDto> GetById(int heroId)
    {
        var hero = await _context.HeroSet.Include(e => e.ItemSlots).Include(e => e.Stats).ThenInclude(e => e.Stat).Include(e => e.Attributes).ThenInclude(e => e.Attribute)
                                     .FirstOrDefaultAsync(e => e.Id == heroId);
        List<StatResponseDTO> statList = new();
        List<AttributeResponseDTO> attributeList = new();
        
        hero.Stats.ToList().ForEach(x => statList.Add(new StatResponseDTO(x.Stat.ShortName, x.Stat.StatName, x.Stat.Description, x.Value)));
        hero.Attributes.ToList().ForEach(x => attributeList.Add(new AttributeResponseDTO(x.Value, x.Attribute.ShortName, x.Attribute.AttributeName, x.Attribute.Description)));
        HeroResponseDto heroResponse = new HeroResponseDto()
        {
            Level = hero.Level,
            Exp = hero.Exp,
            Name = hero.Name,
            Tier = hero.Tier,
            Attributes = attributeList,
            ItemSlots = hero.ItemSlots.ToList(),
            PerkPoints = hero.PerkPoints,
            Stats = statList,
            StatPoints = hero.StatPoints
        };

        return heroResponse;
    }

    private async Task<List<ActorAttribute>> _UpdateHeroAttributes(Hero hero)
    {
        List<ActorAttribute> heroAttributes = await _gameLogicService.CalcAttributes(hero);
        await _context.ActorAttributeSet.AddRangeAsync(heroAttributes);
        await _context.SaveChangesAsync();
        return heroAttributes;
    }

    public async Task<Hero> Create(HeroDTO heroDto)
    {
        Hero hero = new Hero(heroDto, _context);
        await _context.HeroSet.AddAsync(hero);
        await _context.SaveChangesAsync();
        for (int i = 0; i < 20; i++)
        {
            ItemSlot itemSlot = new ItemSlot(hero.Id, _context);
        }

        await _systemService.GenerateStats(hero.Id, 5,5,5,10);
        await _context.SaveChangesAsync();
        await _UpdateHeroAttributes(hero);
        return hero;
    }

    public async Task<Hero> UpdateHero(int heroId, JsonPatchDocument<Hero> heroPatch)
    {
        Hero hero = await _context.HeroSet.FindAsync(heroId);
        if (hero != null)
        {
            heroPatch.ApplyTo(hero);
        }

        return hero;
    }

    public async Task<int> Delete(int Id)
    {
        Hero hero = await _context.HeroSet.FindAsync(Id);
        _context.HeroSet.Remove(hero);
        await _context.SaveChangesAsync();
        return Id;
    }
}