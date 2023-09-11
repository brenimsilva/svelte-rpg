using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models.DTO;

namespace svelte_rpg_backend.Models;

public class Hero
{
    [Key, Required] public int Id { get; set; }
    [Required] public string HeroName { get; set; }
    [ForeignKey("User")] public int UserId { get; set; }
    public IEnumerable<ItemSlot> ItemSlots { get; set; }
    public IEnumerable<HeroStat> Stats { get; set; }
    public IEnumerable<Skill> Skills { get; set; }
    public IEnumerable<HeroAttribute> Attributes { get; set; }
    public IEnumerable<HeroEquipment> HeroEquipments { get; set; }
    public IEnumerable<Perk> Perks { get; set; }
    [Required]public int Level { get; set; }
    [Required]public int Exp { get; set; }
    [Required]public int StatPoints { get; set; }
    [Required]public int PerkPoints { get; set; }
    [DataType(DataType.DateTime)] public DateTime created_at { get; set; }
    [DataType(DataType.DateTime)] public DateTime updated_at { get; set; }


    public Hero()
    {
        
    }

    public Hero(HeroDTO dto, RpgContext _context)
    {
        this.created_at = DateTime.Now;
        this.updated_at = DateTime.Now;
        this.Level = dto.Level;
        this.Exp = dto.Exp;
        this.Id = 0;
        this.UserId = dto.UserId;
        this.HeroName = dto.HeroName;
        this.PerkPoints = dto.PerkPoints;
        this.StatPoints = dto.StatPoints;
        
        _context.HeroSet.AddAsync(this);
    }
}