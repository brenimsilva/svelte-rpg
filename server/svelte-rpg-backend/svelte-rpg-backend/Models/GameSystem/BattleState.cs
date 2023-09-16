using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class BattleState
{
    [Key] public int BattleStateId { get; set; }
    [ForeignKey("Hero")] public int HeroId { get; set; }
    public virtual Hero Hero { get; set; }
    [ForeignKey("Monster")] public int MonsterId { get; set; }
    public virtual Monster Monster { get; set; }
    [Required] public bool Active  { get; set; }
}