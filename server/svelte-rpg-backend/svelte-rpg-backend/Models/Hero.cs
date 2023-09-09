using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Attribute;

namespace svelte_rpg_backend.Models;

public class Hero
{
    [Key, Required] public int Id { get; set; }
    [ForeignKey("User")] public string Owner { get; set; }
    public IEnumerable<CharacterStat> Stats { get; set; }
    public IEnumerable<Skill> Skills { get; set; }
    public IEnumerable<HeroAttribute> Attributes { get; set; }
    public List<Perk> Perks { get; set; }
    public int Level { get; set; }
    public int Exp { get; set; }
    [DataType(DataType.DateTime)] public DateTime created_at { get; set; }
    [DataType(DataType.DateTime)] public DateTime updated_at { get; set; }
}