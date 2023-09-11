using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class ItemAttribute
{
   [Key] public int Id { get; set; }
   [ForeignKey("Attribute")] public int AttributeId { get; set; }
   public virtual Attribute Attribute { get; set; }
   [ForeignKey("Item")] public int ItemId { get; set; }
   [Required]public double Value { get; set; }
}