using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class MonsterLoot
{
    [Key] public int MonsterLootId { get; set; }
    [ForeignKey("MonsterCatalog")] public MonsterEnum MonsterCatalogId { get; set; }
    [ForeignKey("Loot")] public int LootId { get; set; }
    public virtual Loot Loot { get; set; }
    [Required] public double DropChance { get; set; }
}