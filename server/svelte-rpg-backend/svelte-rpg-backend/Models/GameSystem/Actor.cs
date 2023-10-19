using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class Actor
{
    [Key] public int ActorId { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public int Tier { get; set; }
    public virtual ICollection<ActorStat> Stats { get; set; }
    public virtual ICollection<ActorAttribute> Attributes { get; set; }
    [DataType(DataType.DateTime)] public DateTime created_at { get; set; }
    [DataType(DataType.DateTime)] public DateTime updated_at { get; set; }
}