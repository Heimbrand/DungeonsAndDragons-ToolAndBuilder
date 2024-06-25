using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class MagicalArtifactRepository(DnDbContext context) : IMagicalArtifactRepository
{
    public async Task<MagicalArtifact> GetByIdAsync(int id)
    {
        var magicalArtifactById = await context.MagicalArtifacts.FindAsync(id);

        if (magicalArtifactById is null)
            throw new Exception("No MagicalArtifact found with that ID");

        return magicalArtifactById;
    }

    public async Task<IEnumerable<MagicalArtifact>> GetAllAsync()
    {
        var allMagicalArtifacts = await context.MagicalArtifacts.ToListAsync();

        if (allMagicalArtifacts is null)
            throw new Exception("No MagicalArtifacts found");

        return allMagicalArtifacts;
    }

    public async Task<IEnumerable<MagicalArtifact>> GetMany(int start, int count)
    {
        var getManyMagicalArtifacts = await context.MagicalArtifacts.Skip(start).Take(count).ToListAsync();

        if (getManyMagicalArtifacts is null)
            throw new Exception("No MagicalArtifacts found");

        return getManyMagicalArtifacts;
    }

    public async Task AddAsync(MagicalArtifact entity)
    {
        var addMagicalArtifact = await context.MagicalArtifacts.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(MagicalArtifact entity)
    {
        var oldMagicalArtifact = await context.MagicalArtifacts.FindAsync(entity.Id);

        if (oldMagicalArtifact is null)
            throw new Exception("No MagicalArtifact found with that ID");

        context.Entry(oldMagicalArtifact).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var magicalArtifactToDelete = await context.MagicalArtifacts.FindAsync(id);

        if (magicalArtifactToDelete is null)
            throw new Exception("No MagicalArtifact found with that ID");

        context.MagicalArtifacts.Remove(magicalArtifactToDelete);
        context.SaveChangesAsync();
    }

    public async Task<IEnumerable<MagicalArtifact>> GetMagicalArtifactByName(string name)
    {
        var magicalArtifactByName = await context.MagicalArtifacts.ToListAsync();

        var fuzzyScored = magicalArtifactByName.Select(x => new
        {
            Score = FuzzySharp.Fuzz.PartialRatio(x.Name, name), 
            Item = x
        })
            .Where(x => x.Score > 80)
            .OrderByDescending(x => x.Score)
            .Select(x => x.Item);

        return fuzzyScored;
    }

    public async Task<IEnumerable<MagicalArtifact>> GetManyPre5EMagicalArtifacts(int start, int count)
    {
        var getManyPre5EMagicalArtifacts = await context.MagicalArtifacts.Where(m => m.IsPre5E == true).Skip(start).Take(count).ToListAsync();

        if (getManyPre5EMagicalArtifacts is null)
            throw new Exception("No Pre-5E MagicalArtifacts found");

        return getManyPre5EMagicalArtifacts;
    }
}