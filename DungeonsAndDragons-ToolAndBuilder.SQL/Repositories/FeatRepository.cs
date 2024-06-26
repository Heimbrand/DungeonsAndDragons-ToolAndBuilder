using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class FeatRepository(DnDbContext context) : IFeatRepository
{
    public async Task AddAsync(Feat entity)
    {
        var addFeat = await context.Feats.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var featToDelete = await context.Feats.FindAsync(id);

        if (featToDelete is null)
            throw new Exception("No Feat found with that ID");

        context.Feats.Remove(featToDelete);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Feat entity)
    {
        var oldFeat = await context.Feats.FindAsync(entity.Id);

        if (oldFeat is null)
            throw new Exception("No Feat found with that ID");

        context.Entry(oldFeat).CurrentValues.SetValues(entity);
    }

    public async Task<IEnumerable<Feat>> GetAllAsync()
    {
        var allFeats = await context.Feats.ToListAsync();

        if (allFeats is null)
            throw new Exception("No Feats found");

        return allFeats;
    }

    public async Task<Feat> GetByIdAsync(int id)
    {
        var featById = await context.Feats.FindAsync(id);

        if (featById is null)
            throw new Exception("No Feat found with that ID");

        return featById;
    }

    public async Task<IEnumerable<Feat>> GetMany(int start, int count)
    {
        var getManyFeats = await context.Feats.Skip(start).Take(count).ToListAsync();

        if (getManyFeats is null)
            throw new Exception("No Feats found");

        return getManyFeats;
    }


    public async Task<IEnumerable<Feat>> GetFeatByName(string name)
    {
        var featByName = await context.Feats.ToListAsync();

        var fuzzyScored = featByName.Select(feat => new
        {
            Feat = feat,
            Score = FuzzySharp.Fuzz.PartialRatio(feat.Name, name)
        })
            .Where(f => f.Score > 80)
            .OrderByDescending(f => f.Score)
            .Select(f => f.Feat);

        return fuzzyScored;
    }

    public async Task<IEnumerable<Feat>> GetManyPre5EFeats(int start, int count)
    {
        var getManyPre5EFeats = await context.Feats.Where(f => f.IsPre5E == true).Skip(start).Take(count).ToListAsync();

        if (getManyPre5EFeats is null)
            throw new Exception("No Pre-5E Feats found");

        return getManyPre5EFeats;
    }

    public async Task<IEnumerable<Feat>> GetAllPre5EFeats()
    {
        var allPre5EFeats = await context.Feats.Where(f => f.IsPre5E == true).ToListAsync();

        if (allPre5EFeats is null)
            throw new Exception("No Pre-5E Feats found");

        return allPre5EFeats;
    }
}