using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class SkillType
{
   [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public int Id { get; set; }
   [Required, MaxLength(32)]public string Name { get; set; } 
   [Required, MaxLength(64)] public string Description { get; set; }
}