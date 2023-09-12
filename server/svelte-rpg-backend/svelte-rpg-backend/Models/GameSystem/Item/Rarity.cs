using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class Rarity
{
   [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public int Id { get; set; } 
   [Required, StringLength(32)]public string Name { get; set; }
   [Required, StringLength(256)]public string Description { get; set; }
   [Required, StringLength(32)] public string Color { get; set; }
}