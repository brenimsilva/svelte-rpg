using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class HeroEquipment
{
   [Key] public int Id { get; set; } 
   [ForeignKey("EquipmentSlot")] public int EquipmentSlotId { get; set; }
   [ForeignKey("Hero")] public int HeroId { get; set; }
   [ForeignKey("Item")] public int ItemId { get; set; }
}