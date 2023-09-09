using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class Item
{
    [Key] public int Id { get; set; }
    [ForeignKey("ItemType")] public int ItemTypeId { get; set; }
    public string name { get; set; }
}