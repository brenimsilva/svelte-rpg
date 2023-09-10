using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class Skill
{
    [Key]public int Id { get; set; }
    [Required]public string Name { get; set; }
    [ForeignKey("SkillType")] public int SkillTypeId { get; set; }
    public SkillType SkillType { get; set; }
    [Required]public int SkillBasePower { get; set; }
}