using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class UserType
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public UserTypeEnum Id { get; set; }
    [MaxLength(24), Required]public string Name { get; set; } // "admin", "moderator", "player", "spectator"
}