using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;

namespace svelte_rpg_backend.Services;

public class HeroService : IHeroService
{
    private RpgContext _context;
    
    public HeroService(RpgContext ctx)
    {
        this._context = ctx;
    }

    public async Task<Hero> GetById(int heroId)
    {
        return await _context.HeroSet.Include(e => e.ItemSlots)
                                    .FirstOrDefaultAsync(e => e.Id == heroId);
    }

    public async Task<Hero> Create(HeroDTO heroDto)
    {
        Hero hero = new Hero(heroDto, _context);
        await _context.SaveChangesAsync();
        for (int i = 0; i < 20; i++)
        {
            ItemSlot itemSlot = new ItemSlot(hero.Id, _context);
        }
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
        return Id;
    }
}