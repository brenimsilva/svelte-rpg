using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class MonsterAttribute
{
    
   [Key] public int MonsterAttributeId { get; set; }
   [ForeignKey("Attribute")] public AttributeEnum AttributeId { get; set; }
   public virtual Attribute Attribute { get; set; }
   [ForeignKey(nameof(MonsterCatalog))] public MonsterEnum MonsterCatalogId { get; set; }
   [Required]public double Value { get; set; }
}