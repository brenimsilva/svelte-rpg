﻿using System.ComponentModel.DataAnnotations;

namespace svelte_rpg_backend.Models;

public class EquipmentSlot
{
   [Key] public int Id { get; set; } 
   public string Name { get; set; }
}