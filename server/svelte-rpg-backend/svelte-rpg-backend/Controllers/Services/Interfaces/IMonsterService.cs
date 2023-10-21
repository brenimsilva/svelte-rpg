using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Models.DTO.Response;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Services;

public interface IMonsterService
{
    public Task<Monster> MonsterSpawn(MonsterEnum monsterId, int tier);
    public Task<ActorStat> GetStatById(int Id);
}