using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ProficiencyTypeRepository(DnDbContext context) : IProficiencyTypeRepository
{
    public async Task AddAsync(ProficiencyType entity)
    {
        var addProficiencyType = await context.ProficiencyTypes.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var proficiencyTypeToDelete = await context.ProficiencyTypes.FindAsync(id);

        if (proficiencyTypeToDelete is null)
            throw new Exception("No ProficiencyType found with that ID");

        context.ProficiencyTypes.Remove(proficiencyTypeToDelete);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ProficiencyType entity)
    {
        var oldProficiencyType = await context.ProficiencyTypes.FindAsync(entity.Id);

        if (oldProficiencyType is null)
            throw new Exception("No ProficiencyType found with that ID");

        context.Entry(oldProficiencyType).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async  Task<IEnumerable<ProficiencyType>> GetAllAsync()
    {
        var allProficiencyTypes = await context.ProficiencyTypes.ToListAsync();

        if (allProficiencyTypes is null)
            throw new Exception("No ProficiencyTypes found");

        return allProficiencyTypes;
    }

    public async Task<ProficiencyType> GetByIdAsync(int id)
    {
        var proficiencyTypeById = await context.ProficiencyTypes.FindAsync(id);

        if (proficiencyTypeById is null)
            throw new Exception("No ProficiencyType found with that ID");

        return proficiencyTypeById;
    }

    public async Task<IEnumerable<ProficiencyType>> GetMany(int start, int count)
    {
        var getManyProficiencyTypes = await context.ProficiencyTypes.Skip(start).Take(count).ToListAsync();

        if (getManyProficiencyTypes is null)
            throw new Exception("No ProficiencyTypes found");

        return getManyProficiencyTypes;
    }
}