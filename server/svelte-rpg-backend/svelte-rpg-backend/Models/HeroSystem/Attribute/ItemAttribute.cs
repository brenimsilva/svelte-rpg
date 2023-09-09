using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models.Attribute;

public class ItemAttribute
{
   [Key] public int Id { get; set; }
   [ForeignKey("Attribute")] public string AttributeShortName { get; set; }
   [ForeignKey("Item")] public int ItemId { get; set; }
   public double Value { get; set; }
}