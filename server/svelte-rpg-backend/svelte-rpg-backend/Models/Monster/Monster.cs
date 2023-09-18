using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Models.Enums;
using svelte_rpg_backend.Services;

namespace svelte_rpg_backend.Models;

public class Monster : Actor
{
    [Key] public int Id { get; set; }
    public int MonsterCatalogId { get; set; }
    public virtual MonsterCatalog MonsterCatalog { get; set; } 
    public int Level { get; set; }
    public List<ActorAttribute> Attributes { get; set; }
    public List<MonsterLoot> MonsterLoots { get; set; }

    public Monster()
    {
    }

    public Monster(MonsterCatalog mc, int tier)
    {
        this.MonsterCatalogId = mc.Id;
        this.Level = mc.Level;
        this.Name = mc.Name;
        this.Tier = tier;
    }
}