using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models.DTO;

namespace svelte_rpg_backend.Models;

public class Hero : Actor
{
    [ForeignKey("User")] public int UserId { get; set; }
    public IEnumerable<ItemSlot> ItemSlots { get; set; }
    public IEnumerable<Skill> Skills { get; set; }
    public IEnumerable<HeroEquipment> HeroEquipments { get; set; }
    public IEnumerable<Perk> Perks { get; set; }
    [Required]public int Exp { get; set; }
    [Required]public int StatPoints { get; set; }
    [Required]public int PerkPoints { get; set; }

    public Hero()
    {
        
    }

    public Hero(HeroDTO dto)
    {
        this.created_at = DateTime.Now;
        this.updated_at = DateTime.Now;
        this.Id = 0;
        this.UserId = dto.UserId;
        this.Level = dto.Level;
        this.Exp = dto.Exp;
        this.Name = dto.HeroName;
        this.PerkPoints = dto.PerkPoints;
        this.StatPoints = dto.StatPoints;
        this.Tier = 1;
    }
}