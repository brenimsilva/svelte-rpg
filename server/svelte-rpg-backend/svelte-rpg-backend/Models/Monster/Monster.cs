using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Models.Enums;
using svelte_rpg_backend.Services;

namespace svelte_rpg_backend.Models;

public class Monster : Actor
{
    [ForeignKey(nameof(MonsterCatalog))]public MonsterEnum MonsterCatalogId { get; set; }
    public virtual MonsterCatalog MonsterCatalog { get; set; } 
    public List<MonsterLoot> MonsterLoots { get; set; }

    public Monster()
    {
    }

    public Monster(MonsterCatalog mc, int tier)
    {
        this.MonsterCatalogId = mc.MonsterCatalogId;
        this.Level = mc.Level;
        this.Name = mc.Name;
        this.Tier = tier;
    }
}
