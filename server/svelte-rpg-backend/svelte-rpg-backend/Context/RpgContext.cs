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
    public DbSet<Attribute> AttributeSet { get; set; }
    public DbSet<AttributeStatsRatio> AttributeStatRatio { get; set; }
    public DbSet<ItemAttribute> ItemAttributeSet { get; set; }
    public DbSet<ActorAttribute> ActorAttributeSet { get; set; }
    public DbSet<PerkAttribute> PerkAttributeSet { get; set; }
    
    //BackPack
    public DbSet<ItemSlot> ItemSlotSet { get; set; }
    
    //Item
    public DbSet<EquipmentSlot> EquipmentSlotSet { get; set; }
    public DbSet<HeroEquipment> HeroEquipmentSet { get; set; }
    public DbSet<Item> ItemSet { get; set; }
    public DbSet<ItemCatalog> ItemCatalogSet { get; set; }
    public DbSet<ItemType> ItemTypeSet { get; set; }
    public DbSet<Rarity> RaritySet { get; set; }
    
    //Loot
    public DbSet<ItemLoot> ItemLootSet { get; set; }
    public DbSet<Loot> LootSet { get; set; }
    public DbSet<MonsterLoot> MonsterLootSet { get; set; }
    
    //Stat
    public DbSet<ItemStat> ItemStatSet { get; set; }
    public DbSet<ActorStat> ActorStatSet { get; set; }
    public DbSet<PerkStat> PerkStatSet { get; set; }
    public DbSet<Stat> StatSet { get; set; }
    
    //GameSystem
    public DbSet<ActionText> ActionTextSet { get; set; }
    public DbSet<Actor> Actor { get; set; }
    public DbSet<BattleState> BattleStateSet { get; set; }
    public DbSet<Hero> HeroSet { get; set; }
    public DbSet<Perk> PerkSet { get; set; }
    public DbSet<Skill> SkillSet { get; set; }
    public DbSet<SkillType> SkillTypeSet { get; set; }
    
    //Monster
    public DbSet<Monster> MonsterSet { get; set; }
    public DbSet<MonsterCatalog> MonsterCatalogSet { get; set; }
    
    //System
    public DbSet<Config> ConfigSet { get; set; }
    public DbSet<User> UserSet { get; set; }
    public DbSet<UserType> UserTypeSet { get; set; }
}