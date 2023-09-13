using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class MonsterAttribute
{
   [Key] public int Id { get; set; }
   [ForeignKey("Attribute")] public int AttributeId { get; set; }
   public virtual Attribute Attribute { get; set; }
   [ForeignKey("Monster")] public int MonsterId { get; set; }
   [Required]public double Value { get; set; }
   
   public MonsterAttribute() {}

   public MonsterAttribute(AttributeEnum attr, MonsterEnum mob, double value)
   {
      this.Id = 0;
      this.AttributeId = (int)attr;
      this.MonsterId = (int)mob;
      this.Value = value;
   }
}