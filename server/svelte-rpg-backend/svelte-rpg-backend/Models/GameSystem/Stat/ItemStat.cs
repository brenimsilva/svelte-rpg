using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class ItemStat
{
    
   [Key] public int Id { get; set; }
   [ForeignKey("Stat")] public string StatShortName { get; set; }
   [ForeignKey("Item")] public int ItemId { get; set; }
   [Required]public int Value { get; set; }
}