using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Context;

namespace svelte_rpg_backend.Models;

public class ItemSlot
{
    [Key] public int ItemSlotId { get; set; }
    [ForeignKey("Item")] public int? ItemId { get; set; }
    [ForeignKey("Hero")] public int HeroId { get; set; }


    public ItemSlot(int heroId, RpgContext _context)
    {
        this.HeroId = heroId;
        _context.ItemSlotSet.AddAsync(this);
    }
}