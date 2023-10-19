using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class PerkStat
{
   [Key] public int PerkStatId { get; set; }
   [ForeignKey("Stat")] public StatEnum StatId { get; set; }
   public virtual Stat Stat { get; set; }
   [ForeignKey("Perk")] public int PerkId { get; set; }
   [Required] public int Value { get; set; }
}