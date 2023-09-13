using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;

namespace svelte_rpg_backend.Services;

public interface IMonsterService
{
    public Task<List<MonsterAttribute>> generateMonsterStatsAndAttributes(StatGroupDTO stats, AttributeGroupDTO attrs);
}