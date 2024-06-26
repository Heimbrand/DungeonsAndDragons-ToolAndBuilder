using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ConsumableRepository(DnDbContext context) : IConsumableRepository
{
    public async Task<Consumable> GetByIdAsync(int id)
    {
        var consumableById = await context.Consumables.FindAsync(id);

        if (consumableById is null)
            throw new Exception("No Consumable found with that ID");

        return consumableById;
    }

    public async Task<IEnumerable<Consumable>> GetAllAsync()
    {
        var allConsumables = await context.Consumables.ToListAsync();

        if (allConsumables is null)
            throw new Exception("No Consumables found");

        return allConsumables;
    }

    public async Task<IEnumerable<Consumable>> GetMany(int start, int count)
    {
        var getManyConsumables = await context.Consumables.Skip(start).Take(count).ToListAsync();

        if (getManyConsumables is null)
            throw new Exception("No Consumables found");

        return getManyConsumables;
    }

    public async Task AddAsync(Consumable entity)
    {
        var addConsumable = await context.Consumables.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Consumable entity)
    {
        var oldConsumable = await context.Consumables.FindAsync(entity.Id);

        if (oldConsumable is null)
            throw new Exception("No Consumable found with that ID");

        context.Entry(oldConsumable).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var consumableToDelete = await context.Consumables.FindAsync(id);

        if (consumableToDelete is null)
            throw new Exception("No Consumable found with that ID");

        context.Consumables.Remove(consumableToDelete);
        context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Consumable>> GetConsumableByName(string name)
    {
        var ConsumableByName = await context.Consumables.ToListAsync();

        var fuzzyScored = ConsumableByName.Select(x => new
            {
                Consumable = x,
                Score = FuzzySharp.Fuzz.PartialRatio(name, x.Name)
            })
            .Where(x => x.Score > 80)
            .OrderByDescending(x => x.Score)
            .Select(x => x.Consumable);

        if (fuzzyScored is null)
            throw new Exception("No Consumable found with that name");

        return fuzzyScored;
    }

    public async Task<IEnumerable<Consumable>> GetConsumablesByRarity(string rarity)
    {
        var consumableByRarity = await context.Consumables.Where(x => x.Rarity == rarity).ToListAsync();

        if (consumableByRarity is null)
            throw new Exception("No Consumables found with that rarity");

        return consumableByRarity;
    }

    public async Task<IEnumerable<Consumable>> GetAllConsumablesByType(string type)
    {
        var consumablesByType = await context.Consumables.Where(x => x.ConsumableType == type).ToListAsync();

        if (consumablesByType is null)
            throw new Exception("No Consumables found with that type");

        return consumablesByType;
    }

    public async Task<IEnumerable<Consumable>> GetManyConsumablesByType(string type, int start, int count)
    {
        var getManyConsumablesByType = await context.Consumables.Where(x => x.ConsumableType == type).Skip(start).Take(count).ToListAsync();

        if (getManyConsumablesByType is null)
            throw new Exception("No Consumables found with that type");

        return getManyConsumablesByType;
    }

    public async Task<IEnumerable<Consumable>> GetManyPre5EByType(string type, int start, int count)
    {
        var getManyPre5EByType = await context.Consumables.Where(x=>x.IsPre5E == true).Skip(start).Take(count).ToListAsync();

        if (getManyPre5EByType is null)
            throw new Exception("No Consumables found with that type");

        return getManyPre5EByType;
    }
}