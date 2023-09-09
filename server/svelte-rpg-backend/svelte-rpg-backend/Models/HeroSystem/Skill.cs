namespace svelte_rpg_backend.Models;

public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; }
    public SkillType SkillType { get; set; }
    public int SkillBasePower { get; set; }
}