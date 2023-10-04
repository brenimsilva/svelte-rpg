using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO.Response;
using Attribute = svelte_rpg_backend.Models.Attribute;

namespace svelte_rpg_backend.Context;

public class RpgContext: DbContext
{
    private static ThreadLocal<RpgContext> _instance = new ThreadLocal<RpgContext>();

    public RpgContext(DbContextOptions<RpgContext> opts) : base(opts)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hero>().ToTable("Hero");
        modelBuilder.Entity<MonsterCatalog>().ToTable("MonsterCatalog");
        modelBuilder.Entity<Monster>().ToTable("Monster");
    }

    //Attribute
    public DbSet<Attribute> Attribute { get; set; }
    public DbSet<AttributeStatsRatio> AttributeStatRatio { get; set; }
    public DbSet<ItemAttribute> ItemAttributeSet { get; set; }
    public DbSet<ActorAttribute> ActorAttribute { get; set; }
    public DbSet<PerkAttribute> PerkAttribute { get; set; }
    
    //BackPack
    public DbSet<ItemSlot> ItemSlotSet { get; set; }
    
    //Item
    public DbSet<EquipmentSlot> EquipmentSlot { get; set; }
    public DbSet<HeroEquipment> HeroEquipment { get; set; }
    public DbSet<Item> Item { get; set; }
    public DbSet<ItemCatalog> ItemCatalog { get; set; }
    public DbSet<ItemType> ItemType { get; set; }
    public DbSet<Rarity> Rarity { get; set; }
    
    //Loot
    public DbSet<ItemLoot> ItemLoot { get; set; }
    public DbSet<Loot> Loot { get; set; }
    public DbSet<MonsterLoot> MonsterLoot { get; set; }
    
    //Stat
    public DbSet<ItemStat> ItemStat { get; set; }
    public DbSet<ActorStat> ActorStat { get; set; }
    public DbSet<PerkStat> PerkStat { get; set; }
    public DbSet<Stat> Stat { get; set; }
    
    //GameSystem
    public DbSet<ActionText> ActionText { get; set; }
    public DbSet<Actor> Actor { get; set; }
    public DbSet<BattleState> BattleState { get; set; }
    public DbSet<Hero> Hero { get; set; }
    public DbSet<Perk> Perk { get; set; }
    public DbSet<Skill> Skill { get; set; }
    public DbSet<SkillType> SkillType { get; set; }
    
    //Monster
    public DbSet<Monster> Monster { get; set; }
    public DbSet<MonsterCatalog> MonsterCatalog { get; set; }
    
    //System
    public DbSet<Config> Config { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserType> UserType { get; set; }
}