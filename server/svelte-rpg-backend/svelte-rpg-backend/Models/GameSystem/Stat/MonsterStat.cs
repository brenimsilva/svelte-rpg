using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class MonsterStat
{
   [Key] public int MonsterStatId { get; set; }
   [ForeignKey("Stat")] public StatEnum StatId { get; set; }
   public virtual Stat Stat { get; set; }
   [ForeignKey(nameof(MonsterCatalog))] public MonsterEnum MonsterCatalogId { get; set; }
   [Required]public int Value { get; set; }
   public MonsterStat(){}
   
   public MonsterStat(StatEnum statId, MonsterEnum monsterId, int value)
   {
      this.MonsterStatId = 0;
      this.StatId = statId;
      this.MonsterCatalogId = monsterId;
      this.Value = value;
   }
}