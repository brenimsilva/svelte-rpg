using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class ActionText
{
   [Key] public int ActionTextId { get; set; } 
   [Required, MaxLength(32)]public string ActionName { get; set; }
}