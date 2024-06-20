using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ArmorRepository(DnDbContext context) : IArmorRepository
{
    public async Task<Armor> GetByIdAsync(int id)
    {
        var armor = await context.Armors.FindAsync(id);

        if (armor is null)
            throw new Exception("No Armor with that ID exists");

        return armor;
    }
    public async Task<IEnumerable<Armor>> GetAllAsync()
    {
        var armor = await context.Armors.ToListAsync();

        if (armor is null)
            throw new Exception("No Armors found");

        return armor;
    }
    public async Task<IEnumerable<Armor>> GetMany(int start, int count)
    {
        var armor = await context.Armors.Skip(start).Take(count).ToListAsync();

        if (armor is null)
            throw new Exception("No Armors found");

        return armor;
    }
    public async Task AddAsync(Armor entity)
    {
       var armor = await context.Armors.AddAsync(entity);
       await context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Armor entity)
    {
        var oldArmor = await context.Armors.FindAsync(entity.Id);

        if (oldArmor is null)
            throw new Exception("No armor found with that ID"); 

        context.Entry(oldArmor).CurrentValues.SetValues(entity);
        await context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var armorToDelete = await context.Armors.FindAsync(id);

        if (armorToDelete is null)
            throw new Exception("No armor with that ID exist");

        context.Armors.Remove(armorToDelete);
    }
    public async Task<IEnumerable<Armor>> GetArmorByName(string name)
    {
        var armor = await context.Armors.ToListAsync();

        if (armor is null)
            throw new Exception("No Armor with that name exists");

        var fuzzyScored = armor.Select(a => new
        {
            Armors = a,
            Score = FuzzySharp.Fuzz.Ratio(a.Name, name)
        })
            .Where(c => c.Score > 80)
            .OrderByDescending(c => c.Score)
            .Select(c => c.Armors);

        return fuzzyScored;
    }
    public async Task<IEnumerable<Armor>> GetArmorByRarity(string rarity)
    {
        var armorByRarity = await context.Armors.Where(a => a.Rarity == rarity).ToListAsync();

        if (armorByRarity is null)
            throw new Exception("No Armor with that rarity exists");

        return armorByRarity;
    }
    public async Task<IEnumerable<Armor>> GetArmorByType(string type)
    {
        var armorByType = await context.Armors.Where(a => a.ArmorType == type).ToListAsync();

        if (armorByType is null)
            throw new Exception("No Armor with that type exists");

        return armorByType;
    }
    public async Task<IEnumerable<Armor>> GetArmorByPiece(string piece)
    {
        var armorByPiece = await context.Armors.Where(a => a.ArmorPiece == piece).ToListAsync();

        if (armorByPiece is null)
            throw new Exception("No Armor with that piece exists");

        return armorByPiece;

    }
    public async Task<IEnumerable<Armor>> GetManyPre5EArmor(int start, int count)
    {
        var pre5EArmor = await context.Armors.Where(a=> a.IsPre5E == true).Skip(start).Take(count).ToListAsync();

        if (pre5EArmor is null)
            throw new Exception("No Pre5E Armors found");

        return pre5EArmor;
    }
}