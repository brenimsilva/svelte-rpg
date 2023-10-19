using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class MonsterCatalog
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public MonsterEnum MonsterCatalogId { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public virtual ICollection<MonsterStat> Stats { get; set; }
    public virtual ICollection<MonsterAttribute> Attributes { get; set; }
    [DataType(DataType.DateTime)] public DateTime created_at { get; set; }
    [DataType(DataType.DateTime)] public DateTime updated_at { get; set; }
    public IEnumerable<MonsterLoot> MonsterLoots { get; set; }
}
