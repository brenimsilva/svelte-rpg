using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class SkillType
{
   public string Type { get; set; } 
   [ForeignKey("ActionText")]public int ActionId { get; set; }
}