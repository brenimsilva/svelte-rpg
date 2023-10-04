﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using svelte_rpg_backend.Models.Enums;

namespace svelte_rpg_backend.Models;

public class HeroAttribute
{
   [Key] public int HeroAttributeId { get; set; }
   [ForeignKey("Attribute")] public AttributeEnum AttributeId { get; set; }
   public virtual Attribute Attribute { get; set; }
   [ForeignKey("Hero")] public int HeroId { get; set; }
   [Required]public double Value { get; set; }
}