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
    public HeroService(RpgContext ctx, SystemService systemService)
    {
        this._context = ctx;
        this._systemService = systemService;
    }

    public async Task<HeroResponseDto> GetById(int heroId)
    {
        var hero = await _context.HeroSet.Include(e => e.ItemSlots).Include(e => e.Stats).ThenInclude(e => e.Stat)
                                     .FirstOrDefaultAsync(e => e.Id == heroId);
        List<StatResponseDTO> statList = new();
        hero.Stats.ToList().ForEach(x => statList.Add(new StatResponseDTO(x.Stat.ShortName, x.Stat.StatName, x.Stat.Description, x.Value)));
        HeroResponseDto heroResponse = new HeroResponseDto()
        {
            Level = hero.Level,
            Exp = hero.Exp,
            Name = hero.Name,
            Tier = hero.Tier,
            AttributeList = new List<AttributeResponseDTO>(),
            ItemSlots = hero.ItemSlots.ToList(),
            PerkPoints = hero.PerkPoints,
            StatList = statList,
            StatPoints = hero.StatPoints
        };

        return heroResponse;
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