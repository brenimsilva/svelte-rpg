using System.ComponentModel.DataAnnotations;
using svelte_rpg_backend.Models.Attribute;

namespace svelte_rpg_backend.Models;

public class Perk
{
    [Key] public int Id { get; set; }
    public string PerkName { get; set; }
    public IEnumerable<PerkStat> StatsChanged { get; set; }
    public IEnumerable<PerkAttribute> AttributesChanged { get; set; }
}