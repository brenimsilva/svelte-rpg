using System.ComponentModel.DataAnnotations;
namespace svelte_rpg_backend.Models;

public class Monster
{
    [Key] public int Id { get; set; }
    [Required, MaxLength(32)]public string Name { get; set; }
    [Required]public int Level { get; set; }
    public IEnumerable<Loot> Loots { get; set; }
    public IEnumerable<MonsterAttribute> Attributes { get; set; }
    public IEnumerable<MonsterStat> Stats { get; set; }
    [DataType(DataType.DateTime)] public DateTime created_at { get; set; }
    [DataType(DataType.DateTime)] public DateTime updated_at { get; set; }
}