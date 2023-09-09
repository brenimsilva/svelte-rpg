using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class CharacterStat
{
   [Key] public int Id { get; set; }
   [ForeignKey("Stat")] public string StatShortName { get; set; }
   [ForeignKey("Hero")] public int HeroId { get; set; }
   public int Value { get; set; }
}