using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class ItemSlot
{
    [Key] public int ItemSlotId { get; set; }
    [ForeignKey("Item")] public int ItemId { get; set; }
    [ForeignKey("BackPack")] public int BackPackId { get; set; }
}