using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class User
{
    [Key] public int UserId { get; set; }
    [Required, MaxLength(50)] public string UserName { get; set; }
    [Required, EmailAddress] public string Email { get; set; }
    [Required, DataType(DataType.Password)] public string Password { get; set; }
    [Required, ForeignKey("UserType")] public int UserTypeId { get; set; }
    public virtual UserType UserType { get; set; }
    [DataType(DataType.DateTime)] public DateTime created_at { get; set; }
    [DataType(DataType.DateTime)] public DateTime updated_at { get; set; }
    public IEnumerable<Hero> Heroes { get; set; }
}