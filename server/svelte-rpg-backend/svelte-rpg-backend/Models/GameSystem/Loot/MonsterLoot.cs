using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class MonsterLoot
{
    [Key] public int Id { get; set; }
    [ForeignKey("Monster")] public int MonsterId { get; set; }
    [ForeignKey("Loot")] public int LootId { get; set; }
    public virtual Loot Loot { get; set; }
    [Required] public double DropChance { get; set; }
}