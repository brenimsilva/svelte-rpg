using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class HeroEquipment
{
   [Key] public int HeroEquipmentId { get; set; } 
   [ForeignKey("EquipmentSlot")] public EquipmentSlotEnum EquipmentSlotId { get; set; }
   public virtual EquipmentSlot EquipmentSlot { get; set; }
   [ForeignKey("Hero")] public int HeroId { get; set; }
   [ForeignKey("Item")] public int ItemId { get; set; }
   public virtual Item Item { get; set; }
}