using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class HeroStat
{
   [Key] public int Id { get; set; }
   [ForeignKey("Stat")] public string StatShortName { get; set; }
   [ForeignKey("Hero")] public int HeroId { get; set; }
   [Required]public int Value { get; set; }
}