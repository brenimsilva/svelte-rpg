using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class AttributeStatsRatio
{
    [Key] public int AttributeStatsRatioId { get; set; }
    [ForeignKey("Stat")] public StatEnum StatId { get; set; }
    [Required] public Stat Stats { get; set; }
    [ForeignKey("Attribute")] public AttributeEnum AttributeId { get; set; }
    [Required] public Attribute Attributes { get; set; }
    [Required] public double Ratio { get; set; }
}