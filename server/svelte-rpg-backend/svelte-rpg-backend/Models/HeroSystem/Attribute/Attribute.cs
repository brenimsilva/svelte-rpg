using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models.Attribute;

public class Attribute
{
    [Key] public int Id { get; set; }
    public string ShortName { get; set; }
    public string AttributeName { get; set; }
    public string Description { get; set; }
}