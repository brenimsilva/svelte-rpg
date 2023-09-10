using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class BackPack
{
    [Key] public int Id { get; set; }
    // [ForeignKey("Hero")] public int HeroId { get; set; }
    public virtual IEnumerable<ItemSlot> ItemSlots { get; set; }
}