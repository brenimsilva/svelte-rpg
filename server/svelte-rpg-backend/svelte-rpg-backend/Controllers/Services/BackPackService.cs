using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models;

namespace svelte_rpg_backend.Services;

public class BackPackService : IBackPackService
{
    private RpgContext _context;
    public BackPackService(RpgContext ctx)
    {
        this._context = ctx;
    }
    public async Task<BackPack> Create()
    {
        try
        {
            BackPack bp = new BackPack(_context);
            _context.SaveChanges();
            for (int i = 0; i < 20; i++)
            {
                ItemSlot slot = new ItemSlot();
                slot.ItemId = null;
                slot.BackPackId = bp.Id;
                _context.ItemSlotSet.Add(slot);
            }
            return bp;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return new BackPack();
        }
    }
}