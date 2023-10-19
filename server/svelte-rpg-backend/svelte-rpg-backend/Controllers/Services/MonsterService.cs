using Microsoft.EntityFrameworkCore;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Services;

public class MonsterService : IMonsterService
{
    private RpgContext _context;
    private GameLogicService _gameLogicService;
    private SystemService _systemService;
    public MonsterService(RpgContext context, SystemService systemService, GameLogicService gameLogicService)
    {
        this._context = context;
        this._systemService = systemService;
        this._gameLogicService = gameLogicService;
    }

    public async Task<ActorStat> GetStatById(int Id)
    {
        return await _context.ActorStat.FindAsync(Id);
    }
    public async Task<Monster> MonsterSpawn(MonsterEnum monsterId, int tier)
    {
        //Faz a busca no banco do monstro pelo id do enum
        MonsterCatalog catalogedMonster = await _context.MonsterCatalog
            .Include(e => e.Attributes)
            .Include(e => e.Stats)
            .Include(e => e.MonsterLoots)
            .FirstOrDefaultAsync(x => x.MonsterCatalogId == monsterId);
        Monster monster = new Monster()
        {
            ActorId = 0,
            Name = catalogedMonster.Name,
            created_at = DateTime.Now,
            updated_at = DateTime.Now,
            MonsterCatalogId = catalogedMonster.MonsterCatalogId,
            Tier = tier,
            Level = catalogedMonster.Level,
            
        };
        await _context.Monster.AddAsync(monster);
        await _context.SaveChangesAsync();
        await _systemService.GenerateStats(monster.ActorId, 1,1,1,5);
        await _systemService.GenerateAttributes(monster.ActorId, 0, 0, 0, 0, 0, 0, 0);
        await _gameLogicService.UpdateActorAttributes(monster);
        //Faz o calculo do dropchance dos loots pelo tier
        return monster;
    }

    public async Task<Monster> GetById(int id)
    {
        return await _context.Monster.FindAsync(id);
    }
}