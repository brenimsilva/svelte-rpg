using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models.DTO.Response;

public class ItemResponseDTO
{
    
    public string ItemName { get; set; }
    public string Description { get; set; }
    public ItemTypeResponseDTO ItemTypeResponse { get; set; } 
    public RarityResponseDTO Rarity { get; set; }  
    public ActionTextResponseDTO ActionTextResponse { get; set; } 
    public List<AttributeResponseDTO> ItemAttributes { get; set; }
    public virtual List<StatResponseDTO> ItemStats { get; set; }
    public int ItemLevel { get; set; } // +1, +2, +3, ... +13
}