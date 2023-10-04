namespace svelte_rpg_backend.Models.DTO;

public class HeroDTO
{
    public string HeroName { get; set; }
    public int UserId { get; set; }
    public int Level { get; set; }
    public int Exp { get; set; }
    public int StatPoints { get; set; }
    public int PerkPoints { get; set; }
}
