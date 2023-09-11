using Microsoft.AspNetCore.JsonPatch;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;

namespace svelte_rpg_backend.Services;

public interface IHeroService
{
    public Task<Hero> GetById(int heroId);
    public Task<Hero> Create(HeroDTO heroDto);
    public Task<Hero> UpdateHero(int heroId, JsonPatchDocument<Hero> heroPatch);
    public Task<int> Delete(int Id);
}