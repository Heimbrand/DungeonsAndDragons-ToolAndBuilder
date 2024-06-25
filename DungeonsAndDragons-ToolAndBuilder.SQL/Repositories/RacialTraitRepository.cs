using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class RacialTraitRepository(DnDbContext context) : IRacialTraitRepository
{
    public async Task AddAsync(RacialTrait entity)
    {
        var addRacialTrait = await context.RacialTraits.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var racialTraitToDelete = await context.RacialTraits.FindAsync(id);

        if (racialTraitToDelete is null) 
            throw new Exception("No RacialTrait found with that ID");

        context.RacialTraits.Remove(racialTraitToDelete);
        context.SaveChangesAsync();
    }

    public async Task<IEnumerable<RacialTrait>> GetAllAsync()
    {
        var allRacialTraits = await context.RacialTraits.ToListAsync();

        if (allRacialTraits is null)
            throw new Exception("No RacialTraits found");

        return allRacialTraits;
    }

    public async Task<RacialTrait> GetByIdAsync(int id)
    {
        var racialTraitById = await context.RacialTraits.FindAsync(id);

        if (racialTraitById is null)
            throw new Exception("No RacialTrait found with that ID");

        return racialTraitById;
    }

    public async Task<IEnumerable<RacialTrait>> GetMany(int start, int count)
    {
       var getManyRacialTraits = await context.RacialTraits.Skip(start).Take(count).ToListAsync();

        if (getManyRacialTraits is null)
            throw new Exception("No RacialTraits found");

        return getManyRacialTraits;
    }

    public async Task UpdateAsync(RacialTrait entity)
    {
       var oldRacialTrait = await context.RacialTraits.FindAsync(entity.Id);

       if (oldRacialTrait is null)
            throw new Exception("No RacialTrait found with that ID");

        context.Entry(oldRacialTrait).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }
}