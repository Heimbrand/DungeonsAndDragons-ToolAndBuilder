using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class NpcRepository(DnDbContext context) : INpcRepository
{
    public async Task<Npc> GetByIdAsync(int id)
    {
        var npcById = await context.Npcs.FindAsync(id);

        if (npcById is null)
            throw new Exception("No Npc found with that ID");

        return npcById;
    }

    public async Task<IEnumerable<Npc>> GetAllAsync()
    {
        var allNpcs = await context.Npcs.ToListAsync();

        if (allNpcs is null)
            throw new Exception("No Npcs found");

        return allNpcs;
    }

    public async Task<IEnumerable<Npc>> GetMany(int start, int count)
    {
        var getManyNpcs = await context.Npcs.Skip(start).Take(count).ToListAsync();

        if (getManyNpcs is null)
            throw new Exception("No Npcs found");

        return getManyNpcs;
    }

    public async Task AddAsync(Npc entity)
    {
        var addNpc = await context.Npcs.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Npc entity)
    {
        var oldNpc = await context.Npcs.FindAsync(entity.Id);

        if (oldNpc is null)
            throw new Exception("No Npc found with that ID");

        context.Entry(oldNpc).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var npcToDelete = await context.Npcs.FindAsync(id);

        if (npcToDelete is null)
            throw new Exception("No Npc found with that ID");

        context.Npcs.Remove(npcToDelete);
    }

    public async Task<IEnumerable<Npc>> GetNpcByName(string name)
    {
        var npcByName = await context.Npcs.ToListAsync();

        var fuzzyScored = npcByName.Select(n => new
            {
                Score = FuzzySharp.Fuzz.PartialRatio(n.Name, name),
                Npc = n
            })
            .Where(n => n.Score > 80)
            .OrderByDescending(n => n.Score)
            .Select(n => n.Npc);

        return fuzzyScored;
    }

    public async Task<IEnumerable<Npc>> GetAllLivingNpcs()
    {
       var allLivingNpcs = await context.Npcs.Where(n => n.IsDead == false).ToListAsync();

        if (allLivingNpcs is null)
            throw new Exception("No Living Npcs found");

        return allLivingNpcs;
    }

    public async Task<IEnumerable<Npc>> GetAllDeadNpcs()
    {
        var allDeadNpcs = await context.Npcs.Where(n => n.IsDead == true).ToListAsync();

        if (allDeadNpcs is null)
            throw new Exception("No Dead Npcs found");

        return allDeadNpcs;
    }
}