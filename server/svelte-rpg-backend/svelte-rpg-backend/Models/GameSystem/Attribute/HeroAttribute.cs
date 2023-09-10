using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class HeroAttribute
{
   [Key] public int Id { get; set; }
   [ForeignKey("Attribute"), Required] public string AttributeShortName { get; set; }
   [ForeignKey("Hero"), Required] public int HeroId { get; set; }
   [Required]public double Value { get; set; }
}