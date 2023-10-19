using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class Attribute
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public AttributeEnum AttributeId { get; set; }
    [Required, StringLength(10)]public string ShortName { get; set; }
    [Required, StringLength(32)]public string AttributeName { get; set; }
    [Required, StringLength(256)]public string Description { get; set; }

    public Attribute()
    {
        
    }
}