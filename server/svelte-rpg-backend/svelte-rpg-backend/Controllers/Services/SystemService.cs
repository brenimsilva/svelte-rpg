using Microsoft.AspNetCore.Mvc;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Models.Enums;
using svelte_rpg_backend.Util;
using Attribute = svelte_rpg_backend.Models.Attribute;

namespace svelte_rpg_backend.Services;

public class SystemService : ISystemService
{
    private RpgContext _context;
    private MonsterService _monsterService;
    private GameLogicService _gameLogicService;
    public SystemService(RpgContext context, MonsterService monsterService, GameLogicService glService)
    {
        this._context = context;
        this._monsterService = monsterService;
        this._gameLogicService = glService;
    }

    private List<Attribute> _StartAttributes()
    {
        List<Attribute> attributes = new List<Attribute>();
        attributes.Add(new () {Id = 1, AttributeName = "Health Points", ShortName = "HP", Description = "Represents the current health of a character or entity in a game or simulation, indicating how much damage it can withstand before being defeated"});
        attributes.Add(new () {Id = 2, AttributeName = "Max Health Points", ShortName = "MHP", Description = "Denotes the maximum potential health a character or entity can have, setting an upper limit on their survivability"});
        attributes.Add(new () {Id = 3, AttributeName = "Attack", ShortName = "ATK", Description = "Signifies the offensive strength or damage-dealing capability of a character, determining the harm it inflicts on opponents"});
        attributes.Add(new () {Id = 4, AttributeName = "Defense", ShortName = "DEF", Description = "Reflects the defensive capabilities of a character, reducing the damage taken from incoming attacks and enhancing overall resilience"});
        attributes.Add(new () {Id = 5, AttributeName = "Evasion", ShortName = "EVS", Description = "Represents a character's ability to dodge or evade incoming attacks, reducing the likelihood of being hit"});
        attributes.Add(new () {Id = 6, AttributeName = "Critical Chance", ShortName = "CRTC", Description = "Indicates the probability or likelihood of a character landing a critical hit, which typically results in increased damage"});
        attributes.Add(new () {Id = 7, AttributeName = "Critical Damage", ShortName = "CRTD", Description = "Specifies the additional damage multiplier applied when a critical hit occurs, amplifying the impact of such attacks"});
        return attributes;
    }
    private async Task<List<AttributeStatsRatio>> _StartAttributeStatsRatio()
    {
        List<AttributeStatsRatio> attributeStatsRatioList = new();
        attributeStatsRatioList.Add(new AttributeStatsRatio() {Id = 0, AttributeId = (int)AttributeEnum.MaxHealthPoints, Ratio = 5.0, StatId = (int)StatEnum.Vitality});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {Id = 0, AttributeId = (int)AttributeEnum.MaxHealthPoints, Ratio = 1.5, StatId = (int)StatEnum.Strength});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {Id = 0, AttributeId = (int)AttributeEnum.Attack, Ratio = 2.0, StatId = (int)StatEnum.Strength});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {Id = 0, AttributeId = (int)AttributeEnum.Defense, Ratio = 0.5, StatId = (int)StatEnum.Dexterity});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {Id = 0, AttributeId = (int)AttributeEnum.CritDamage, Ratio = 1.0, StatId = (int)StatEnum.Dexterity});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {Id = 0, AttributeId = (int)AttributeEnum.Defense, Ratio = 1.0, StatId = (int)StatEnum.Vitality});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {Id = 0, AttributeId = (int)AttributeEnum.Evasion, Ratio = 1.0, StatId = (int)StatEnum.Agility});
        return attributeStatsRatioList;
    }
    private List<Stat> _StartStats()
    {
        List<Stat> stats = new List<Stat>();
        stats.Add(new Stat() { Id = 1, StatName = "Strength", ShortName = "STR", Description = "Represents the physical power and muscle strength of a character, influencing Attack and Max Health Points" });
        stats.Add(new Stat() { Id = 2, StatName = "Vitality", ShortName = "VIT", Description = "Denotes the overall health and endurance of a character, affecting Max Health Points and Defense" });
        stats.Add(new Stat() { Id = 3, StatName = "Dexterity", ShortName = "DEX", Description = "Signifies a character's finesse, precision, and hand-eye coordination, influencing Defense and Critical Damage" });
        stats.Add(new Stat() { Id = 4, StatName = "Agility", ShortName = "AGI", Description = "Reflects a character's speed, reflexes, and nimbleness, affecting Evasion Rate" });
        return stats;
    }
    private List<Rarity> _startRarities()
    {
        List<Rarity> stats = new List<Rarity>();
        stats.Add(new Rarity() {Id = 1, Name = "Common", Description = "Items with this rarity level are easily found and typically have basic attributes or abilities. They are often used for basic purposes in the game", Color = "#FFFFFF"});
        stats.Add(new Rarity() {Id = 2, Name = "Uncommon", Description = "Uncommon items are somewhat harder to come by than common ones. They offer slightly improved attributes or unique features, making them more valuable to players.", Color = "#119100"});
        stats.Add(new Rarity() {Id = 3, Name = "Rare", Description = "Rare items are relatively scarce and offer significant enhancements or unique abilities. Players often seek these items for their substantial benefits", Color = "#004180"});
        stats.Add(new Rarity() {Id = 4, Name = "Epic", Description = "Epic items are exceptionally rare and possess extraordinary attributes or abilities. They are highly coveted by players and can be game-changing", Color = "#9400f7"});
        stats.Add(new Rarity() {Id = 5, Name = "Master Work", Description = "Master Work items are expertly crafted and represent the pinnacle of item quality. They provide exceptional advantages and are considered prized possessions by players", Color = "#f7c010"});
        stats.Add(new Rarity() {Id = 6, Name = "Legendary", Description = "Legendary items are the rarest and most powerful items in the game. They possess legendary abilities, unique effects, or unparalleled stats, making them the most sought-after and prestigious items", Color = "#f7033c"});
        return stats;
    }
    private List<ItemType> _startItemType()
    {
        List<ItemType> itemTypes = new List<ItemType>();
        itemTypes.Add(new ItemType() {Id = 1, Name = "Equipment", Description = "A Item that can be equipped (Check slot)"});
        itemTypes.Add(new ItemType() {Id = 2, Name = "Consumable", Description = "A Item that can be consumable during fight"});
        itemTypes.Add(new ItemType() {Id = 3, Name = "Miscellaneous", Description = "Maybe it has some value at the shop..."});
        itemTypes.Add(new ItemType() {Id = 4, Name = "Gem", Description = "With this Item you can upgrade your equipments"});
        return itemTypes;
    }
    private List<SkillType> _startSkillType()
    {
        List<SkillType> skillTypes = new List<SkillType>();
        skillTypes.Add(new SkillType() {Id = 1, Name = "Buff", Description = "A Skill that increases your power"});
        skillTypes.Add(new SkillType() {Id = 2, Name = "Offensive", Description = "A Offensive skill that deals damage"});
        skillTypes.Add(new SkillType() {Id = 3, Name = "Cure", Description = "This is skill will heal your HP"});
        return skillTypes;
    }

    private async Task<List<MonsterCatalog>> _startMonsters()
    {
        List<MonsterCatalog> monsters = new List<MonsterCatalog>();
        MonsterCatalog Rat = new MonsterCatalog()
        {
            Id = (int)MonsterEnum.Rat, Name = "Rat",
            created_at = DateTime.Now, updated_at = DateTime.Now, Level = 1, Tier = 1
        };
        monsters.Add(Rat);
        await _context.MonsterCatalogSet.AddRangeAsync(monsters);
        await _context.SaveChangesAsync();
        await GenerateStats(Rat.Id, 1, 1, 1, 5);
        await GenerateAttributes(Rat.Id, 0, 0, 0, 0, 0, 0, 0);
        await _context.SaveChangesAsync();
        await _gameLogicService.UpdateActorAttributes(Rat);
        
        return monsters;
    }

    public async Task<List<ActorStat>> GenerateStats(int actorId, int str, int dex, int agi, int vit)
    {
        List<ActorStat> statList = new List<ActorStat>();
        ActorStat STR = new ActorStat(StatEnum.Strength, actorId, str);
        ActorStat DEX = new ActorStat(StatEnum.Dexterity, actorId, dex);
        ActorStat AGI = new ActorStat(StatEnum.Agility, actorId, agi);
        ActorStat VIT = new ActorStat(StatEnum.Vitality, actorId, vit);
        statList.AddRange(new []
        {
            STR,DEX,AGI,VIT
        });
        await _context.ActorStatSet.AddRangeAsync(statList);
        return statList;
    }

    public async Task<List<ActorAttribute>> GenerateAttributes(int actorId, double mhp, double hp, double atk, double def, double evs, double crtc, double crtd)
    {
        List<ActorAttribute> actorAttributes = new List<ActorAttribute>();
        ActorAttribute MHP = new ActorAttribute(AttributeEnum.MaxHealthPoints, actorId, mhp);
        ActorAttribute HP = new ActorAttribute(AttributeEnum.HealthPoints, actorId, hp);
        ActorAttribute ATK = new ActorAttribute(AttributeEnum.Attack, actorId, atk);
        ActorAttribute DEF = new ActorAttribute(AttributeEnum.Defense, actorId, def);
        ActorAttribute EVS = new ActorAttribute(AttributeEnum.Evasion, actorId, evs);
        ActorAttribute CRTC = new ActorAttribute(AttributeEnum.CritChance, actorId, crtc);
        ActorAttribute CRTD = new ActorAttribute(AttributeEnum.CritDamage, actorId, crtd);
        actorAttributes.AddRange(new []
        {
            MHP,HP, ATK, DEF, CRTD, CRTC, EVS
        });
        await _context.ActorAttributeSet.AddRangeAsync(actorAttributes);
        return actorAttributes;

    }

    private List<UserType> _startUserTypes()
    {
        List<UserType> userTypes = new List<UserType>();
        foreach (UserTypeEnum enumValue in Enum.GetValues(typeof(UserTypeEnum)))
        {
            userTypes.Add(new UserType()
            {
                Id = (int)enumValue,
                Name = StringUtilities.PascalToWord(enumValue.ToString())
            });
        } 
        return userTypes;
    }
    private List<EquipmentSlot> _StartEquipmentSlot()
    {
        List<EquipmentSlot> equipmentSlots = new List<EquipmentSlot>();
        foreach (EquipmentSlotEnum enumValue in Enum.GetValues(typeof(EquipmentSlotEnum)))
        {
            equipmentSlots.Add(new EquipmentSlot()
            {
                Id = (int)enumValue,
                Name = StringUtilities.PascalToWord(enumValue.ToString())
            });
        } 
        return equipmentSlots;
    }


    public async Task<bool> DataBaseInit()
    {
        try
        {
            var tasks = new Task[]
            {
                _context.AttributeSet.AddRangeAsync(_StartAttributes()),
                _context.EquipmentSlotSet.AddRangeAsync(_StartEquipmentSlot()),
                _context.ItemTypeSet.AddRangeAsync(_startItemType()),
                _context.RaritySet.AddRangeAsync(_startRarities()),
                _context.SkillTypeSet.AddRangeAsync(_startSkillType()),
                _context.StatSet.AddRangeAsync(_StartStats()),
                _context.UserTypeSet.AddRangeAsync(_startUserTypes()),
                _context.AttributeStatRatio.AddRangeAsync(await _StartAttributeStatsRatio()),
            };
            await _startMonsters();
            await Task.WhenAll(tasks);
            await _context.SaveChangesAsync();
            return true;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}