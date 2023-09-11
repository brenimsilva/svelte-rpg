using svelte_rpg_backend.Models;

namespace svelte_rpg_backend.Services;

public interface IBackPackService
{
     public Task<BackPack> Create();
     // public Task<ItemSlot> GetSlotById(int slotId);
     // public Task<ItemSlot> AddItemToSlot(Item item, int slotId);
}