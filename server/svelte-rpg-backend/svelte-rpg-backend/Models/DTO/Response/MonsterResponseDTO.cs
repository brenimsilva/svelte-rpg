namespace svelte_rpg_backend.Models.DTO.Response;

public class MonsterResponseDTO
{
    
    public int Level { get; set; } 
    public string Name { get; set; }
    public int Tier { get; set; }
    public Dictionary<string, StatResponseDTO> Stats { get; set; }
    public Dictionary<string, AttributeResponseDTO> Attributes { get; set; }
    public List<MonsterLoot> Loot { get; set; } 
}