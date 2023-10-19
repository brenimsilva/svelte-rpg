using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Models.DTO.Response;
using svelte_rpg_backend.Util;

namespace svelte_rpg_backend.Services;

public class HeroService : IHeroService
{
    private RpgContext _context;
    private SystemService _systemService;
    private GameLogicService _gameLogicService;
    public HeroService(RpgContext ctx, SystemService systemService, GameLogicService glService)
    {
        this._context = ctx;
        this._systemService = systemService;
        this._gameLogicService = glService;
    }

    public async Task<HeroResponseDto> GetById(int heroId)
    {
        var hero = await _context.Hero
            .Include(e => e.ItemSlots)
            .ThenInclude(e => e.Item)
            .ThenInclude(e => e.ItemCatalog)
            .ThenInclude(e => e.Rarity)
            .Include(e => e.Stats)
            .ThenInclude(e => e.Stat)
            .Include(e => e.Attributes)
            .ThenInclude(e => e.Attribute)
            .FirstOrDefaultAsync(e => e.ActorId == heroId);
        IEnumerable<ItemSlot> itemSlotList = _context.ItemSlotSet.Where(e => e.HeroId == hero.ActorId).Include(e => e.Item);
        List<StatResponseDTO> statList = new();
        List<AttributeResponseDTO> attributeList = new();
        
        hero.Stats.ToList().ForEach(x => statList.Add(new StatResponseDTO(x.Stat.ShortName, x.Stat.StatName, x.Stat.Description, x.Value)));
        hero.Attributes.ToList().ForEach(x => attributeList.Add(new AttributeResponseDTO(x.Value, x.Attribute.ShortName, x.Attribute.AttributeName, x.Attribute.Description)));
        Dictionary<string, AttributeResponseDTO> attrDictionary = DataUtilities.ConvertToDictionary(attributeList, "ShortName");
        Dictionary<string, StatResponseDTO> statDictionary = DataUtilities.ConvertToDictionary(statList, "ShortName");
        List<ItemSlotResponseDTO> listItemSlotResponse = new();
        foreach (var item in hero.ItemSlots)
        {
            if (item.Item != null)
            {
                ItemResponseDTO itemResponseDto = new()
                {
                    Description = item.Item.ItemCatalog.Description,
                    ItemLevel = item.Item.ItemLevel,
                    ItemName = item.Item.ItemCatalog.Name,
                    Rarity = new RarityResponseDTO()
                    {
                        Description = item.Item.ItemCatalog.Rarity.Description,
                        Name = item.Item.ItemCatalog.Rarity.Name,
                        Color = item.Item.ItemCatalog.Rarity.Color
                    },
                    ActionTextResponse = new ActionTextResponseDTO()
                    {
                        ActionName = item.Item.ItemCatalog.Name
                    },
                    ItemTypeResponse = new ItemTypeResponseDTO()
                    {
                        Name = item.Item.ItemCatalog.ItemType.Name,
                        Description = item.Item.ItemCatalog.ItemType.Description
                    },
                    ItemAttributes = new(), //TODO
                    ItemStats = new() // TODO
                };
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


    public async Task<Hero> Create(HeroDTO heroDto)
    {
        Hero hero = new Hero(heroDto);
        await _context.Hero.AddAsync(hero);
        await _context.SaveChangesAsync();
        for (int i = 0; i < 20; i++)
        {
            ItemSlot itemSlot = new ItemSlot(hero.ActorId, _context);
        }
        await _systemService.GenerateStats(hero.ActorId, 5,5,5,10);
        await _systemService.GenerateAttributes(hero.ActorId, 0,0,0,0,0,0,0);
        await _gameLogicService.UpdateActorAttributes(hero);
        await _context.SaveChangesAsync();

        return hero;
    }

    public async Task<Hero> UpdateHero(int heroId, JsonPatchDocument<Hero> heroPatch)
    {
        Hero hero = await _context.Hero.FindAsync(heroId);
        if (hero != null)
        {
            heroPatch.ApplyTo(hero);
        }

        return hero;
    }

    public async Task<int> Delete(int Id)
    {
        Hero hero = await _context.Hero.FindAsync(Id);
        _context.Hero.Remove(hero);
        await _context.SaveChangesAsync();
        return Id;
    }
}