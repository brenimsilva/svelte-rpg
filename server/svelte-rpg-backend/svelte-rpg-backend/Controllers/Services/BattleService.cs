using svelte_rpg_backend.Context;
namespace svelte_rpg_backend.Services;
public class BattleService {
    private RpgContext _context;
    public BattleService(RpgContext ctx) {
        this._context = ctx;
    }
}
