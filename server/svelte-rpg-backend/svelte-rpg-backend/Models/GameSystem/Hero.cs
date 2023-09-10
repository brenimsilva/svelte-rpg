using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class Hero
{
    [Key, Required] public int Id { get; set; }
    [ForeignKey("User")] public string Owner { get; set; }
    public IEnumerable<HeroStat> Stats { get; set; }
    public IEnumerable<Skill> Skills { get; set; }
    public IEnumerable<HeroAttribute> Attributes { get; set; }
    public List<Perk> Perks { get; set; }
    [Required]public int Level { get; set; }
    [Required]public int Exp { get; set; }
    [Required]public int StatPoints { get; set; }
    [Required]public int PerkPoints { get; set; }
    [DataType(DataType.DateTime)] public DateTime created_at { get; set; }
    [DataType(DataType.DateTime)] public DateTime updated_at { get; set; }
}