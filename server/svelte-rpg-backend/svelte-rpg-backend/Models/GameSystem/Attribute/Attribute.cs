using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class Attribute
{
    [Key] public int Id { get; set; }
    [Required, StringLength(10)]public string ShortName { get; set; }
    [Required, StringLength(32)]public string AttributeName { get; set; }
    [Required, StringLength(128)]public string Description { get; set; }
}