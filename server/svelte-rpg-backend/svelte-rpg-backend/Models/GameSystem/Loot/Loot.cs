using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class Loot
{
    [Key] public int LootId { get; set; }
    public virtual IEnumerable<ItemLoot> ItemLoot { get; set; }
    [Required]public int Exp { get; set; }
    [Required]public int Gold { get; set; }
}