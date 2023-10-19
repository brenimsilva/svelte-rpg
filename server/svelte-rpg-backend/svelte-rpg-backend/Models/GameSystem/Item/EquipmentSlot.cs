using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class EquipmentSlot
{
   [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public EquipmentSlotEnum EquipmentSlotId { get; set; } 
   [Required, MaxLength(24)]public string Name { get; set; }
}