using Microsoft.AspNetCore.Mvc;
using Attribute = svelte_rpg_backend.Models.Attribute;

namespace svelte_rpg_backend.Services;

public interface ISystemService
{
    public Task<bool> DataBaseInit();
}