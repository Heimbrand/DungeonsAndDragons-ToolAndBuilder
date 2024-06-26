using System.Security.Cryptography.X509Certificates;
using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class FactionRepository(DnDbContext context) : IFactionRepository
{
    public async Task<Faction> GetByIdAsync(int id)
    {
        var factionById = await context.Factions.FindAsync(id);

        if (factionById is null)
            throw new Exception("No Faction found with that ID");

        return factionById;
    }

    public async Task<IEnumerable<Faction>> GetAllAsync()
    {
        var allFactions = await context.Factions.ToListAsync();

        if (allFactions is null)
            throw new Exception("No Factions found");

        return allFactions;
    }

    public async Task<IEnumerable<Faction>> GetMany(int start, int count)
    {
        var getManyFactions = await context.Factions.Skip(start).Take(count).ToListAsync();

        if (getManyFactions is null)
            throw new Exception("No Factions found");

        return getManyFactions;
    }

    public async Task AddAsync(Faction entity)
    {
        var addFaction = await context.Factions.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Faction entity)
    {
        var oldFaction = await context.Factions.FindAsync(entity.Id);

        if (oldFaction is null)
            throw new Exception("No Faction found with that ID");

        context.Entry(oldFaction).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var factionToDelete = await context.Factions.FindAsync(id);

        if (factionToDelete is null)
            throw new Exception("No Faction found with that ID");

        context.Factions.Remove(factionToDelete);
        context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Faction>> GetAllPre5EFactions()
    {
        var allPre5EFactions = await context.Factions.Where(f => f.IsPre5E == true).ToListAsync();

        if (allPre5EFactions is null)
            throw new Exception("No Pre-5E Factions found");

        return allPre5EFactions;
    }

    public async Task<IEnumerable<Faction>> GetFactionByName(string name)
    {
        var factionByName = await context.Factions.ToListAsync();

        var fuzzyScored = factionByName.Select(f => new
            {
                Faction = f,
                Score = FuzzySharp.Fuzz.Ratio(f.Name, name)
            })
            .Where(f => f.Score > 80)
            .OrderByDescending(f => f.Score)
            .Select(f => f.Faction);

        return fuzzyScored;

    }
}