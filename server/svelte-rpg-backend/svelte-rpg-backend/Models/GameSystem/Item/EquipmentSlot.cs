using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class EquipmentSlot
{
   [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public int Id { get; set; } 
   [Required, MaxLength(24)]public string Name { get; set; }
}