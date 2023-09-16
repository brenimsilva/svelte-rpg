namespace svelte_rpg_backend.Models.DTO;

public class AttributeGroupDTO
{
    public double HealthPoints { get; set; }
    public double MaxHealthPoints { get; set; }
    public double Attack { get; set; }
    public double Defense { get; set; }
    public double Evasion { get; set; }
    public double CritChance { get; set; }
    public double CritDamage { get; set; }
}