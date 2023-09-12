using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class ItemType
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public int Id { get; set; } 
    [Required]public string Name { get; set; }
    [Required]public string Description { get; set; }
}