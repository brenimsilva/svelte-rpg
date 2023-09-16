using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models.DTO.Response;

public class ItemResponseDTO
{
    
    public string ItemName { get; set; }
    public string Description { get; set; }
    public ItemType ItemType { get; set; } // TODO: CRIAR DTO
    public Rarity Rarity { get; set; } // TODO: CRIAR DTO
    public ActionText ActionText { get; set; } // TODO: CRIAR DTO
    public List<AttributeResponseDTO> ItemAttributes { get; set; }
    public virtual List<StatResponseDTO> ItemStats { get; set; }
    public int ItemLevel { get; set; } // +1, +2, +3, ... +13
}