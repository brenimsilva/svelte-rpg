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
    public SystemService(RpgContext context)
    {
        this._context = context;
    }

    private List<Attribute> _StartAttributes()
    {
        List<Attribute> attributes = new List<Attribute>();
        attributes.Add(new () {AttributeId = AttributeEnum.HealthPoints, AttributeName = "Health Points", ShortName = "HP", Description = "Represents the current health of a character or entity in a game or simulation, indicating how much damage it can withstand before being defeated"});
        attributes.Add(new () {AttributeId = AttributeEnum.MaxHealthPoints, AttributeName = "Max Health Points", ShortName = "MHP", Description = "Denotes the maximum potential health a character or entity can have, setting an upper limit on their survivability"});
        attributes.Add(new () {AttributeId = AttributeEnum.Attack, AttributeName = "Attack", ShortName = "ATK", Description = "Signifies the offensive strength or damage-dealing capability of a character, determining the harm it inflicts on opponents"});
        attributes.Add(new () {AttributeId = AttributeEnum.Defense, AttributeName = "Defense", ShortName = "DEF", Description = "Reflects the defensive capabilities of a character, reducing the damage taken from incoming attacks and enhancing overall resilience"});
        attributes.Add(new () {AttributeId = AttributeEnum.Evasion, AttributeName = "Evasion", ShortName = "EVS", Description = "Represents a character's ability to dodge or evade incoming attacks, reducing the likelihood of being hit"});
        attributes.Add(new () {AttributeId = AttributeEnum.CritChance, AttributeName = "Critical Chance", ShortName = "CRTC", Description = "Indicates the probability or likelihood of a character landing a critical hit, which typically results in increased damage"});
        attributes.Add(new () {AttributeId = AttributeEnum.CritDamage, AttributeName = "Critical Damage", ShortName = "CRTD", Description = "Specifies the additional damage multiplier applied when a critical hit occurs, amplifying the impact of such attacks"});
        return attributes;
    }
    private async Task<List<AttributeStatsRatio>> _StartAttributeStatsRatio()
    {
        List<AttributeStatsRatio> attributeStatsRatioList = new();
        attributeStatsRatioList.Add(new AttributeStatsRatio() {AttributeStatsRatioId = 0, AttributeId = AttributeEnum.MaxHealthPoints, Ratio = 5.0, StatId = StatEnum.Vitality});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {AttributeStatsRatioId = 0, AttributeId = AttributeEnum.MaxHealthPoints, Ratio = 1.5, StatId = StatEnum.Strength});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {AttributeStatsRatioId = 0, AttributeId = AttributeEnum.Attack, Ratio = 2.0, StatId = StatEnum.Strength});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {AttributeStatsRatioId = 0, AttributeId = AttributeEnum.Defense, Ratio = 0.5, StatId = StatEnum.Dexterity});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {AttributeStatsRatioId = 0, AttributeId = AttributeEnum.CritDamage, Ratio = 1.0, StatId = StatEnum.Dexterity});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {AttributeStatsRatioId = 0, AttributeId = AttributeEnum.Defense, Ratio = 1.0, StatId = StatEnum.Vitality});
        attributeStatsRatioList.Add(new AttributeStatsRatio() {AttributeStatsRatioId = 0, AttributeId = AttributeEnum.Evasion, Ratio = 1.0, StatId = StatEnum.Agility});
        return attributeStatsRatioList;
    }
    private List<Stat> _StartStats()
    {
        List<Stat> stats = new List<Stat>();
        stats.Add(new Stat() { StatId = StatEnum.Strength, StatName = "Strength", ShortName = "STR", Description = "Represents the physical power and muscle strength of a character, influencing Attack and Max Health Points" });
        stats.Add(new Stat() { StatId = StatEnum.Vitality, StatName = "Vitality", ShortName = "VIT", Description = "Denotes the overall health and endurance of a character, affecting Max Health Points and Defense" });
        stats.Add(new Stat() { StatId = StatEnum.Dexterity, StatName = "Dexterity", ShortName = "DEX", Description = "Signifies a character's finesse, precision, and hand-eye coordination, influencing Defense and Critical Damage" });
        stats.Add(new Stat() { StatId = StatEnum.Agility, StatName = "Agility", ShortName = "AGI", Description = "Reflects a character's speed, reflexes, and nimbleness, affecting Evasion Rate" });
        return stats;
    }
    private List<Rarity> _startRarities()
    {
        List<Rarity> stats = new List<Rarity>();
        stats.Add(new Rarity() {RarityId = RarityEnum.Common, Name = "Common", Description = "Items with this rarity level are easily found and typically have basic attributes or abilities. They are often used for basic purposes in the game", Color = "#FFFFFF"});
        stats.Add(new Rarity() {RarityId = RarityEnum.Uncommon, Name = "Uncommon", Description = "Uncommon items are somewhat harder to come by than common ones. They offer slightly improved attributes or unique features, making them more valuable to players.", Color = "#119100"});
        stats.Add(new Rarity() {RarityId = RarityEnum.Rare, Name = "Rare", Description = "Rare items are relatively scarce and offer significant enhancements or unique abilities. Players often seek these items for their substantial benefits", Color = "#004180"});
        stats.Add(new Rarity() {RarityId = RarityEnum.Epic, Name = "Epic", Description = "Epic items are exceptionally rare and possess extraordinary attributes or abilities. They are highly coveted by players and can be game-changing", Color = "#9400f7"});
        stats.Add(new Rarity() {RarityId = RarityEnum.Masterwork, Name = "Master Work", Description = "Master Work items are expertly crafted and represent the pinnacle of item quality. They provide exceptional advantages and are considered prized possessions by players", Color = "#f7c010"});
        stats.Add(new Rarity() {RarityId = RarityEnum.Legendary, Name = "Legendary", Description = "Legendary items are the rarest and most powerful items in the game. They possess legendary abilities, unique effects, or unparalleled stats, making them the most sought-after and prestigious items", Color = "#f7033c"});
        return stats;
    }
    private List<ItemType> _startItemType()
    {
        List<ItemType> itemTypes = new List<ItemType>();
        itemTypes.Add(new ItemType() {ItemTypeId = ItemTypeEnum.Equipment, Name = "Equipment", Description = "A Item that can be equipped (Check slot)"});
        itemTypes.Add(new ItemType() {ItemTypeId = ItemTypeEnum.Consumable, Name = "Consumable", Description = "A Item that can be consumable during fight"});
        itemTypes.Add(new ItemType() {ItemTypeId = ItemTypeEnum.Miscellaneous, Name = "Miscellaneous", Description = "Maybe it has some value at the shop..."});
        itemTypes.Add(new ItemType() {ItemTypeId = ItemTypeEnum.Gem, Name = "Gem", Description = "With this Item you can upgrade your equipments"});
        return itemTypes;
    }
    private List<SkillType> _startSkillType()
    {
        List<SkillType> skillTypes = new List<SkillType>();
        skillTypes.Add(new SkillType() {SkillTypeId = SkillTypeEnum.Buff, Name = "Buff", Description = "A Skill that increases your power"});
        skillTypes.Add(new SkillType() {SkillTypeId = SkillTypeEnum.Offensive, Name = "Offensive", Description = "A Offensive skill that deals damage"});
        skillTypes.Add(new SkillType() {SkillTypeId = SkillTypeEnum.Cure, Name = "Cure", Description = "This is skill will heal your HP"});
        return skillTypes;
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
        await _context.ActorStat.AddRangeAsync(statList);
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
        await _context.ActorAttribute.AddRangeAsync(actorAttributes);
        return actorAttributes;
    }

    private List<UserType> _startUserTypes()
    {
        List<UserType> userTypes = new List<UserType>();
        foreach (UserTypeEnum enumValue in Enum.GetValues(typeof(UserTypeEnum)))
        {
            userTypes.Add(new UserType()
            {
                Id = enumValue,
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
                EquipmentSlotId = enumValue,
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
                _context.Attribute.AddRangeAsync(_StartAttributes()),
                _context.EquipmentSlot.AddRangeAsync(_StartEquipmentSlot()),
                _context.ItemType.AddRangeAsync(_startItemType()),
                _context.Rarity.AddRangeAsync(_startRarities()),
                _context.SkillType.AddRangeAsync(_startSkillType()),
                _context.Stat.AddRangeAsync(_StartStats()),
                _context.UserType.AddRangeAsync(_startUserTypes()),
                _context.AttributeStatRatio.AddRangeAsync(await _StartAttributeStatsRatio()),
            };
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