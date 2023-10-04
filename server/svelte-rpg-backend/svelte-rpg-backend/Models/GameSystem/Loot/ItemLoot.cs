using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class ItemLoot
{
   [Key] public int ItemLootId { get; set; } 
   [ForeignKey("Loot")] public int LootId { get; set; }
   [ForeignKey("Item")] public int ItemId { get; set; }
   public virtual Item Item { get; set; }
}