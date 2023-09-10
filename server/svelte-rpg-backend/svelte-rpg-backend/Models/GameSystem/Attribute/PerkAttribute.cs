using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class PerkAttribute
{
   [Key] public int Id { get; set; }
   [ForeignKey("Attribute"), Required] public string AttributeShortName { get; set; }
   [ForeignKey("Perk"), Required] public int PerkId { get; set; }
   [Required]public double Value { get; set; }
}