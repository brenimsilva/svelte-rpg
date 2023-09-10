using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class Item
{
    [Key] public int Id { get; set; }
    [ForeignKey("ItemType")] public int ItemTypeId { get; set; }
    [ForeignKey("Rarity")] public int RarityId { get; set; }
    [ForeignKey("ActionText")] public int ActionTextId { get; set; }
    [Required, MaxLength(32)]public string Name { get; set; }
    [Required] public int ItemLevel { get; set; } // +1, +2, +3, ... +13
}