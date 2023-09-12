using Microsoft.AspNetCore.Mvc;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models;
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
        attributes.Add(new () {Id = 1, AttributeName = "Health Points", ShortName = "HP", Description = "Represents the current health of a character or entity in a game or simulation, indicating how much damage it can withstand before being defeated"});
        attributes.Add(new () {Id = 2, AttributeName = "Max Health Points", ShortName = "MHP", Description = "Denotes the maximum potential health a character or entity can have, setting an upper limit on their survivability"});
        attributes.Add(new () {Id = 3, AttributeName = "Attack", ShortName = "ATK", Description = "Signifies the offensive strength or damage-dealing capability of a character, determining the harm it inflicts on opponents"});
        attributes.Add(new () {Id = 4, AttributeName = "Defense", ShortName = "DEF", Description = "Reflects the defensive capabilities of a character, reducing the damage taken from incoming attacks and enhancing overall resilience"});
        attributes.Add(new () {Id = 5, AttributeName = "Evasion", ShortName = "EVS", Description = "Represents a character's ability to dodge or evade incoming attacks, reducing the likelihood of being hit"});
        attributes.Add(new () {Id = 6, AttributeName = "Critical Chance", ShortName = "CRTC", Description = "Indicates the probability or likelihood of a character landing a critical hit, which typically results in increased damage"});
        attributes.Add(new () {Id = 7, AttributeName = "Critical Damage", ShortName = "CRTD", Description = "Specifies the additional damage multiplier applied when a critical hit occurs, amplifying the impact of such attacks"});
        return attributes;
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

    private List<Monster> _startMonsters()
    {
        List<Monster> monsters = new List<Monster>();
        // monsters.Add(new Monster() {Id = 1, Name = "Dragon", Level = 40,Attributes = new List<MonsterAttribute>() {new MonsterAttribute() {}}});
        return monsters;
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
                _context.UserTypeSet.AddRangeAsync(_startUserTypes())
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