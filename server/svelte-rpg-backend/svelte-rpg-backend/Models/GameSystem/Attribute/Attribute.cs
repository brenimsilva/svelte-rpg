using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class Attribute
{
    [Key]public int Id { get; set; }
    [MaxLength(10), Required]public string ShortName { get; set; }
    [MaxLength(32), Required]public string AttributeName { get; set; }
    [MaxLength(128), Required]public string Description { get; set; }
}