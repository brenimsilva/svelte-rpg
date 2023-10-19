namespace svelte_rpg_backend.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Battle {

    [Key] public int BattleId {get;set;}
    [ForeignKey("Hero")] public int HeroId {get;set;}
    public virtual Hero Hero {get;set;}
    [ForeignKey("Monster")] public int MonsterId {get;set;}
    public virtual Monster Monster {get;set;}

}
