using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ProficienceRepository(DnDbContext context) : IProficienceRepository
{
    public async Task AddAsync(Proficiency entity)
    {
        var addProficience = await context.Proficiencies.AddAsync(entity);
        context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var proficienceToDelete = await context.Proficiencies.FindAsync(id);

        if (proficienceToDelete is null)
            throw new Exception("No Proficience found with that ID");

        context.Proficiencies.Remove(proficienceToDelete);
        context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Proficiency entity)
    {
        var oldProficience = await context.Proficiencies.FindAsync(entity.Id);

        if (oldProficience is null)
            throw new Exception("No Proficience found with that ID");

        context.Entry(oldProficience).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }
    public async Task<IEnumerable<Proficiency>> GetAllAsync()
    {
        var allProficience = await context.Proficiencies.ToListAsync();

        if (allProficience is null)
            throw new Exception("No Proficiencies found");

        return allProficience;
    }
    public async Task<Proficiency> GetByIdAsync(int id)
    {
        var proficienceById = await context.Proficiencies.FindAsync(id);

        if (proficienceById is null)
            throw new Exception("No Proficience found with that ID");

        return proficienceById;
    }
    public async Task<IEnumerable<Proficiency>> GetMany(int start, int count)
    {
       var getManyProficience = await context.Proficiencies.Skip(start).Take(count).ToListAsync();

        if (getManyProficience is null)
            throw new Exception("No Proficience found");

        return getManyProficience;
    }
    public async Task<IEnumerable<Proficiency>> GetProficiencyByName(string name)
    {
        var proficienceByName = await context.Proficiencies.ToListAsync();

        var fuzzyScored = proficienceByName.Select(x => new
            {
                Proficience = x,
                Score = FuzzySharp.Fuzz.PartialRatio(x.Name, name)
            })
            .Where(x => x.Score > 80)
            .OrderByDescending(x => x.Score)
            .Select(x => x.Proficience);

        return fuzzyScored;
    }
    public async Task<IEnumerable<Proficiency>> GetProficiencyByType(string type)
    {
        var proficienceByType = await context.Proficiencies
            .Include(x => x.ProficiencyType)
            .Where(x => x.ProficiencyType.Name == type)
            .ToListAsync();

        if (proficienceByType is null)
            throw new Exception("No Proficience found with that type");

        return proficienceByType;
    }
}