using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class Rarity
{
   [Key] public int Id { get; set; } 
   public string Name { get; set; }
   public string Description { get; set; }
}