using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Context;

namespace svelte_rpg_backend.Models;

public class BackPack
{
    [Key] public int Id { get; set; }
    // [ForeignKey("Hero")] public int HeroId { get; set; }
    public virtual IEnumerable<ItemSlot> ItemSlots { get; set; }

    public BackPack(){}
    public BackPack(RpgContext _context)
    {
        this.Id = 0;
        _context.BackPackSet.AddAsync(this);
    }
}