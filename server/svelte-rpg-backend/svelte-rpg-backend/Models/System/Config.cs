using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class Config
{
    [Key] public int Id { get; set; } 
    public string Name { get; set; } // Ratios [Exp, Ascention, Drop, ...] On/Off [CalendarEvent, NewFeatures, ...]
    public double Value { get; set; }
}