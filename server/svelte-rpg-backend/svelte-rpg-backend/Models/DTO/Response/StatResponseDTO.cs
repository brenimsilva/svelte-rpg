namespace svelte_rpg_backend.Models.DTO.Response;

public class StatResponseDTO
{
    public string ShortName { get; set; }
    public string StatName { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }

    public StatResponseDTO(string shortName, string statName, string description, int value)
    {
        this.ShortName = shortName;
        this.StatName = statName;
        this.Description = description;
        this.Value = value;
    }
}