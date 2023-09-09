using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class UserType
{
    [Key] public int Id { get; set; }
    public string Name { get; set; } // "admin", "moderator", "player", "spectator"
}