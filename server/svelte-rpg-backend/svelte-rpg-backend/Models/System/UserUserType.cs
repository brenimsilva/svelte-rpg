using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class UserUserType
{
    [Key] public int UserUserTypeId { get; set; }
    public Guid UserGuid { get; set; }
    [ForeignKey(nameof(UserType))]public UserTypeEnum UserType { get; set; }
}