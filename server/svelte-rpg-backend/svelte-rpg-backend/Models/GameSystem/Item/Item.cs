using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class Item 
{
    [Key] public int ItemId { get; set; }
    [ForeignKey(nameof(ItemCatalog))] public ItemEnum ItemCatalogId { get; set; }
    public virtual IEnumerable<ItemAttribute> ItemAttributes { get; set; }
    public virtual IEnumerable<ItemStat> ItemStats { get; set; }
    public virtual ItemCatalog ItemCatalog { get; set; }
    [Required] public int ItemLevel { get; set; } // +1, +2, +3, ... +13
}