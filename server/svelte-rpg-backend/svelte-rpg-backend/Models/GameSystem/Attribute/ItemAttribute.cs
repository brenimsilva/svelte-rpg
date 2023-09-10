using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class ItemAttribute
{
   [Key] public int Id { get; set; }
   [ForeignKey("Attribute"), Required] public string AttributeShortName { get; set; }
   [ForeignKey("Item"), Required] public int ItemId { get; set; }
   [Required]public double Value { get; set; }
}