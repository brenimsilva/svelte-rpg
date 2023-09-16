using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class AttributeStatsRatio
{
    [Key] public int Id { get; set; }
    [ForeignKey("Stat")] public int StatId { get; set; }
    [Required] public Stat Stats { get; set; }
    [ForeignKey("Attribute")] public int AttributeId { get; set; }
    [Required] public Attribute Attributes { get; set; }
    [Required] public double Ratio { get; set; }
}