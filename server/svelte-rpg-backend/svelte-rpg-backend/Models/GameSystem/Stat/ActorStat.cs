using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class ActorStat
{
   [Key] public int ActorStatId { get; set; }
   [ForeignKey("Stat")] public StatEnum StatId { get; set; }
   public virtual Stat Stat { get; set; }
   [ForeignKey("Actor")] public int ActorId { get; set; }
   [Required]public int Value { get; set; }
   
   
   public ActorStat() {}

   public ActorStat(StatEnum statId, int actorId, int value)
   {
      this.ActorStatId = 0;
      this.StatId = statId;
      this.ActorId = actorId;
      this.Value = value;
   }
}