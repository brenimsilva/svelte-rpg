namespace svelte_rpg_backend.Models.DTO.Response;

public class AttributeResponseDTO
{
    public double Value { get; set; }
    public string ShortName { get; set; }
    public string AttributeName { get; set; }
    public string Description { get; set; }

    public AttributeResponseDTO(double value, string shortName, string attributeName, string description)
    {
        this.Value = value;
        this.Description = description;
        this.ShortName = shortName;
        this.AttributeName = attributeName;
    }
}