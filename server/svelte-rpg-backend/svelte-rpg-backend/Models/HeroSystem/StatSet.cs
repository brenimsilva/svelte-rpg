using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class StatSet
{
    public int Id { get; set; }
    public int HP { get; set; } // Health Points
    public int MAX_HP { get; set; } // Maximum Health Points
    public int ATK { get; set; } // Attack
    public int DEF { get; set; } // Defense
    public int EVS { get; set;} // Evasion
    public int CRTC { get; set; } //Crit Chance
    public int CRTD { get; set; } // Crit Damage
    [ForeignKey("Hero")] public int HeroId { get; set; }
    
}