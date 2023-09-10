using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class EquipmentSlot
{
   [Key] public int Id { get; set; } 
   [Required, MaxLength(24)]public string Name { get; set; }
}