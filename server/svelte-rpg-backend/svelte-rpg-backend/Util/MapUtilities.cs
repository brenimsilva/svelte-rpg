using System.Runtime.CompilerServices;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO.Response;
using svelte_rpg_backend.Models.Interfaces;

namespace svelte_rpg_backend.Util;

public class MapUtilities
{

    public static Dictionary<string, T> ConvertToDictionary<T>(List<T> list, string propertyToKey)
    {
        if (string.IsNullOrEmpty(propertyToKey) || list == null || !list.Any())
        {
            throw new ArgumentException("Invalid input parameters.");
        }
        var propertyInfo = typeof(T).GetProperty(propertyToKey);
        if (propertyInfo == null)
        {
            throw new ArgumentException($"Property '{propertyToKey}' not found in type '{typeof(T).Name}'.");
        }
        var dictionary = new Dictionary<string, T>();
        foreach (var item in list)
        { 
            string? keyValue = propertyInfo.GetValue(item)?.ToString();

            if (!string.IsNullOrEmpty(keyValue) && !dictionary.ContainsKey(keyValue))
            {
                dictionary.Add(keyValue, item);
            }
        }

        return dictionary;
    }

    public static MonsterResponseDTO ToMonsterResponseDTO(Monster monster)
    {
        
        List<StatResponseDTO> statList = new();
        List<AttributeResponseDTO> attributeList = new();
        
        monster.Stats.ToList().ForEach(x => statList.Add(new StatResponseDTO(x.Stat.ShortName, x.Stat.StatName, x.Stat.Description, x.Value)));
        monster.Attributes.ToList().ForEach(x => attributeList.Add(new AttributeResponseDTO(x.Value, x.Attribute.ShortName, x.Attribute.AttributeName, x.Attribute.Description)));
        Dictionary<string, AttributeResponseDTO> attrDictionary = ConvertToDictionary(attributeList, "ShortName");
        Dictionary<string, StatResponseDTO> statDictionary = ConvertToDictionary(statList, "ShortName");
        MonsterResponseDTO dto = new MonsterResponseDTO()
        {
            Attributes = attrDictionary,
            Stats = statDictionary,
            Level = monster.Level,
            Name = monster.Name,
            Tier = monster.Tier,
            Loot = new List<MonsterLoot>()
        };
        return dto;
    }

    public static HeroResponseDto ToHeroResponseDTO(Hero hero)
    {
        List<StatResponseDTO> statList = new();
        List<AttributeResponseDTO> attributeList = new();
        
        hero.Stats.ToList().ForEach(x => statList.Add(new StatResponseDTO(x.Stat.ShortName, x.Stat.StatName, x.Stat.Description, x.Value)));
        hero.Attributes.ToList().ForEach(x => attributeList.Add(new AttributeResponseDTO(x.Value, x.Attribute.ShortName, x.Attribute.AttributeName, x.Attribute.Description)));
        Dictionary<string, AttributeResponseDTO> attrDictionary = ConvertToDictionary(attributeList, "ShortName");
        Dictionary<string, StatResponseDTO> statDictionary = ConvertToDictionary(statList, "ShortName");
        List<ItemSlotResponseDTO> listItemSlotResponse = ToItemSlotResponseDTO(hero.ItemSlots);
        HeroResponseDto heroResponse = new HeroResponseDto()
        {
            Level = hero.Level,
            Exp = hero.Exp,
            Name = hero.Name,
            Tier = hero.Tier,
            Attributes =  attrDictionary,
            ItemSlots = listItemSlotResponse, 
            PerkPoints = hero.PerkPoints,
            Stats = statDictionary,
            StatPoints = hero.StatPoints
        };
        return heroResponse;
    }

    public static List<ItemSlotResponseDTO> ToItemSlotResponseDTO(IEnumerable<ItemSlot> ItemSlots)
    {
        List<ItemSlotResponseDTO> listItemSlotResponse = new();
        foreach (var item in ItemSlots)
        {
            if (item.Item != null)
            {
                var itemResponseDto = ToItemResponseDTO(item.Item);
                ItemSlotResponseDTO itemSlotResponseDto = new()
                {
                    Item = itemResponseDto
                };
                listItemSlotResponse.Add(itemSlotResponseDto);
            }
            else
            {
                listItemSlotResponse.Add(new ItemSlotResponseDTO());
            }
        }
        return listItemSlotResponse;
    }

    public static ItemResponseDTO ToItemResponseDTO(Item item)
    {
        ItemResponseDTO itemResponseDto = new()
        {
            Description = item.ItemCatalog.Description,
            ItemLevel = item.ItemLevel,
            ItemName = item.ItemCatalog.Name,
            Rarity = ToRarityResponseDTO(item.ItemCatalog),
            ActionTextResponse = new ActionTextResponseDTO()
            {
                ActionName = item.ItemCatalog.Name
            },
            ItemTypeResponse = new ItemTypeResponseDTO()
            {
                Name = item.ItemCatalog.ItemType.Name,
                Description = item.ItemCatalog.ItemType.Description
            },
            ItemAttributes = new(), //TODO
            ItemStats = new() // TODO
        };
        return itemResponseDto;
    }

    public static RarityResponseDTO ToRarityResponseDTO(IMensurable obj)
    {
        var rarityResponse = new RarityResponseDTO()
        {
            Description = obj.Rarity.Description,
            Name = obj.Rarity.Name,
            Color = obj.Rarity.Color
        };
         return rarityResponse;
    }
}