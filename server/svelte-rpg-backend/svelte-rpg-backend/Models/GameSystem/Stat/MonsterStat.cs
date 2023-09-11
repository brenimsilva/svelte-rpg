using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class MonsterStat
{
   [Key] public int Id { get; set; }
   [ForeignKey("Stat")] public int StatId { get; set; }
   public virtual Stat Stat { get; set; }
   [ForeignKey("Monster")] public int MonsterId { get; set; }
   [Required]public int Value { get; set; }
}