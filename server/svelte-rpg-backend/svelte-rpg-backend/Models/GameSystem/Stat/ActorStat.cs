using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class ActorStat
{
   [Key] public int Id { get; set; }
   [ForeignKey("Stat")] public int StatId { get; set; }
   public virtual Stat Stat { get; set; }
   [ForeignKey("Actor")] public int ActorId { get; set; }
   [Required]public int Value { get; set; }
   
   
   public ActorStat() {}

   public ActorStat(StatEnum statId, int actorId, int value)
   {
      this.Id = 0;
      this.StatId = (int)statId;
      this.ActorId = actorId;
      this.Value = value;
   }
}