using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class HeroStat
{
   [Key] public int HeroStatId { get; set; }
   [ForeignKey("Stat")] public StatEnum StatId { get; set; }
   public virtual Stat Stat { get; set; }
   [ForeignKey("Hero")] public int HeroId { get; set; }
   [Required]public int Value { get; set; }
}