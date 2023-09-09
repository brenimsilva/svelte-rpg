using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class Item
{
    [Key] public int Id { get; set; }
    [ForeignKey("ItemType")] public int ItemTypeId { get; set; }
    [ForeignKey("Rarity")] public int RarityId { get; set; }
    public string Name { get; set; }
    public int ItemLevel { get; set; } // +1, +2, +3, ... +13
}