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
    public MonsterService(RpgContext context, GameLogicService _glService)
    {
        this._context = context;
        this._gameLogicService = _glService;
    }

    public async Task<ActorStat> GetStatById(int Id)
    {
        return await _context.ActorStatSet.FindAsync(Id);
    }
    public async Task<Monster> MonsterSpawn(MonsterEnum monsterId, int tier)
    {
        //Faz a busca no banco do monstro pelo id do enum
        MonsterCatalog catalogedMonster = await _context.MonsterCatalogSet.Include(e => e.Attributes)
            .Include(e => e.Stats)
            .Include(e => e.MonsterLoots)
            .FirstOrDefaultAsync(x => x.Id == (int)monsterId);
        //Spawna novo monster
        Monster monster = new Monster();
        
        monster.Name = catalogedMonster.Name;
        //Faz o calculo dos stats pelo tier
        //Faz o calculo dos attributes pelo stats
        //Faz o calculo do dropchance dos loots pelo tier
        //
        return monster;
    }
}