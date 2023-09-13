namespace svelte_rpg_backend.Models.DTO;

public class AttributeGroupDTO
{
    public int HealthPoints { get; set; }
    public int MaxHealthPoints { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Evasion { get; set; }
    public int CritChance { get; set; }
    public int CritDamage { get; set; }
}