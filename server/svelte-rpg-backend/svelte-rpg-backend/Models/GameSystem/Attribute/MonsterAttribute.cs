using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models.Attribute;

public class MonsterAttribute
{
   [Key] public int Id { get; set; }
   [ForeignKey("Attribute")] public string AttributeShortName { get; set; }
   [ForeignKey("Monster")] public int MonsterId { get; set; }
   public double Value { get; set; }
}