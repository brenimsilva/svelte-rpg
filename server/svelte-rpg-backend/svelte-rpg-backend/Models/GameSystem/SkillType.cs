using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class SkillType
{
   [Key] public int Id { get; set; }
   [Required, MaxLength(32)]public string Type { get; set; } 
   [Required, MaxLength(64)] public string Description { get; set; }
}