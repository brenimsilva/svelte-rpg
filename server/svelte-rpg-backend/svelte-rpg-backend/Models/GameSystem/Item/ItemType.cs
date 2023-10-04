using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class ItemType
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public ItemTypeEnum ItemTypeId { get; set; } 
    [Required]public string Name { get; set; }
    [Required]public string Description { get; set; }
}