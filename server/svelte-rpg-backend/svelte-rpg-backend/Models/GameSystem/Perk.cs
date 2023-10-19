using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class Perk
{
    [Key] public int PerkId { get; set; }
    [Required, MaxLength(24)]public string PerkName { get; set; }
    public IEnumerable<PerkStat> StatsChanged { get; set; }
    public IEnumerable<PerkAttribute> AttributesChanged { get; set; }
}