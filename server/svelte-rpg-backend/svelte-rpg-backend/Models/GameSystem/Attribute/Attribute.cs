using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class Attribute
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public int Id { get; set; }
    [Required, StringLength(10)]public string ShortName { get; set; }
    [Required, StringLength(32)]public string AttributeName { get; set; }
    [Required, StringLength(128)]public string Description { get; set; }
}