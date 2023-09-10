using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class Loot
{
    [Key] public int Id { get; set; }
    public virtual List<ItemLoot> ItemLoot { get; set; }
    public int Exp { get; set; }
    public int Gold { get; set; }
}