using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models.DTO;

public class UserDTO
{
    [Required, MaxLength(50), Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public string UserName { get; set; }
    [Required, EmailAddress] public string Email { get; set; }
    [Required, DataType(DataType.Password)] public string Password { get; set; }
}