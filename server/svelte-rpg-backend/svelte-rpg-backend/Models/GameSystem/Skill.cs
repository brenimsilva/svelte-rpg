using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class Skill
{
    [Key]public int Id { get; set; }
    [Required]public string Name { get; set; }
    [ForeignKey("SkillType")] public int SkillTypeId { get; set; }
    public virtual SkillType SkillType { get; set; }
    [ForeignKey("ActionText")]public int ActionId { get; set; }
    public virtual ActionText ActionText { get; set; }
    [Required] public string Description { get; set; }
    [Required]public int SkillBasePower { get; set; }
}