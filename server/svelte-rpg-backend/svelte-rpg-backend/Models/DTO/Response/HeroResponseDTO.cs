namespace svelte_rpg_backend.Models.DTO.Response;

public class HeroResponseDto
{
    public int Level { get; set; } 
    public int Exp { get; set; }
    public string Name { get; set; }
    public int PerkPoints { get; set; }
    public int StatPoints { get; set; }
    public int Tier { get; set; }
    public List<StatResponseDTO> StatList { get; set; }
    public List<AttributeResponseDTO> AttributeList { get; set; }
    public List<ItemSlot> ItemSlots { get; set; } // TODO: Criar DTO
}