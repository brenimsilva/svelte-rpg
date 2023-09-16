using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;

namespace svelte_rpg_backend.Services;

public interface IGameLogicService
{

    public Task<List<ActorAttribute>>CalcAttributes(Actor actor); //TODO: Adicionar equipamentos/passivas/ascention/GameConfigs ao calculo
}