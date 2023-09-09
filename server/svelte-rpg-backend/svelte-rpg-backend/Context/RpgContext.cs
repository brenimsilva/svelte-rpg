using svelte_rpg_backend.Models;

namespace svelte_rpg_backend.Context;

public class RpgContext
{
    public RpgContext(DbContextOptions<RpgContext> opts) : base(opts)
    {
        
    }
    
    public DbSet<Item> ItemSet { get; set; }
}