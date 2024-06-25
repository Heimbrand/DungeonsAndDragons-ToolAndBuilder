using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SubRacialTraitRepository(DnDbContext context) : ISubRacialTraitRepository
{
    public async Task AddAsync(SubRacialTrait entity)
    {
        var addSubRacialTrait = await context.SubRacialTraits.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var subRacialTraitToDelete = await context.SubRacialTraits.FindAsync(id);

        if (subRacialTraitToDelete is null)
            throw new Exception("No SubRacialTrait found with that ID");

        context.SubRacialTraits.Remove(subRacialTraitToDelete);
        context.SaveChangesAsync();
    }

    public async Task<IEnumerable<SubRacialTrait>> GetAllAsync()
    {
       var allSubRacialTraits = await context.SubRacialTraits.ToListAsync();

        if (allSubRacialTraits is null)
            throw new Exception("No SubRacialTraits found");

        return allSubRacialTraits;
    }

    public async Task<SubRacialTrait> GetByIdAsync(int id)
    {
        var subRacialTraitById = await context.SubRacialTraits.FindAsync(id);

        if (subRacialTraitById is null)
            throw new Exception("No SubRacialTrait found with that ID");

        return subRacialTraitById;
    }

    public async Task<IEnumerable<SubRacialTrait>> GetMany(int start, int count)
    {
        var getManySubRacialTraits = await context.SubRacialTraits.Skip(start).Take(count).ToListAsync();

        if (getManySubRacialTraits is null)
            throw new Exception("No SubRacialTraits found");

        return getManySubRacialTraits;
    }

    public async Task UpdateAsync(SubRacialTrait entity)
    {
        var oldSubRacialTrait = await context.SubRacialTraits.FindAsync(entity.Id);

        if (oldSubRacialTrait is null)
            throw new Exception("No SubRacialTrait found with that ID");

        context.Entry(oldSubRacialTrait).CurrentValues.SetValues(entity);
    }
}