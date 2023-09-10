﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace svelte_rpg_backend.Models;

public class Stat
{
    [Key] public int Id { get; set; }
    public string ShortName { get; set; }
    public string StatName { get; set; }
    public string Description { get; set; }
}