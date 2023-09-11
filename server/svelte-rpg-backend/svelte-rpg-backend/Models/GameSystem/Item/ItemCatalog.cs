using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class ItemCatalog
{
   [Key] public int Id { get; set; }
   [Required, MaxLength(32)]public string Name { get; set; }
   [MaxLength(64)] public string Description { get; set; }
   [ForeignKey("ItemType")] public int ItemTypeId { get; set; }
   public virtual ItemType ItemType { get; set; }
   [ForeignKey("Rarity")] public int RarityId { get; set; }
   public virtual Rarity Rarity { get; set; }
   [ForeignKey("ActionText")] public int ActionTextId { get; set; }
   public virtual ActionText ActionText { get; set; }
}