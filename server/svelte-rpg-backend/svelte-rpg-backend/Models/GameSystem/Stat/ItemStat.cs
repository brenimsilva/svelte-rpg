using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class ItemStat
{
    
   [Key] public int ItemStatId { get; set; }
   [ForeignKey("Stat")] public StatEnum StatId { get; set; }
   public virtual Stat Stat { get; set; }
   [ForeignKey("Item")] public int ItemId { get; set; }
   [Required]public int Value { get; set; }
}