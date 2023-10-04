using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class ActorAttribute
{
   [Key] public int ActorAttributeId { get; set; }
   [ForeignKey("Attribute")] public AttributeEnum AttributeId { get; set; }
   public virtual Attribute Attribute { get; set; }
   [ForeignKey("Actor")] public int ActorId { get; set; }
   [Required]public double Value { get; set; }
   
   public ActorAttribute() {}

   public ActorAttribute(AttributeEnum attr, int actorId, double value)
   {
      this.ActorAttributeId = 0;
      this.AttributeId = attr;
      this.ActorId = actorId;
      this.Value = value;
   }
   public ActorAttribute(AttributeEnum attr, double value)
   {
      this.ActorAttributeId = 0;
      this.AttributeId = attr;
      this.Value = value;
   }
}

