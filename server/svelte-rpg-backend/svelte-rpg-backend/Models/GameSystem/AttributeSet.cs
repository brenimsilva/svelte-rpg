using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class AttributeSet
{
    public int Id { get; set; }
    public int STR { get; set; } // Strength
    public int VIT { get; set; } // Vitality
    public int DEX { get; set; } // Dexterity
    public int AGI { get; set; } // Agility
    [ForeignKey("Hero")] public int HeroId { get; set; }
}