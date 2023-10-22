using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Context;

namespace svelte_rpg_backend.Models;

public class ItemSlot
{
    [Key] public int ItemSlotId { get; set; }
    [ForeignKey(nameof(Models.Item))] public int? ItemId { get; set; }
    public virtual Item? Item { get; set; } = null;
    [ForeignKey(nameof(Hero))] public int HeroId { get; set; }

    public ItemSlot() {}
    public ItemSlot(Hero hero)
    {
        this.ItemSlotId = 0;
        this.ItemId = null;
        this.HeroId = hero.ActorId;
    }
}