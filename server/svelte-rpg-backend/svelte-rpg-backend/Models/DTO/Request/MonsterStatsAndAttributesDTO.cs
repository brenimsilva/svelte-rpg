namespace svelte_rpg_backend.Models.DTO;

public class MonsterStatsAndAttributesDTO
{
   public List<ActorAttribute> Attributes { get; set; } 
   public List<ActorStat> Stats { get; set; }
}