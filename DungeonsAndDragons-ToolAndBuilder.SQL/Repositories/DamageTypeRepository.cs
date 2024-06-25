using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class DamageTypeRepository(DnDbContext context) : IDamageTypeRepository
{
    public async Task<DamageType> GetByIdAsync(int id)
    {
        var damageTypeById = await context.DamageTypes.FindAsync(id);

        if (damageTypeById is null)
            throw new Exception("No DamageType found with that ID");

        return damageTypeById;
    }
    public async Task<IEnumerable<DamageType>> GetAllAsync()
    {
        var allDamageTypes = await context.DamageTypes.ToListAsync();

        if (allDamageTypes is null)
            throw new Exception("No DamageTypes found");

        return allDamageTypes;
    }
    public async Task<IEnumerable<DamageType>> GetMany(int start, int count)
    {
        var getManyDamageTypes = await context.DamageTypes.Skip(start).Take(count).ToListAsync();

        if (getManyDamageTypes is null)
            throw new Exception("No DamageTypes found");

        return getManyDamageTypes;
    }
    public async Task AddAsync(DamageType entity)
    {
        var addDamageType = await context.DamageTypes.AddAsync(entity);
        context.SaveChangesAsync();
    }
    public async Task UpdateAsync(DamageType entity)
    {
        var oldDamageType = await context.DamageTypes.FindAsync(entity.Id);

        if (oldDamageType is null)
            throw new Exception("No DamageType found with that ID");

        context.Entry(oldDamageType).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
       var deleteDamageType = await context.DamageTypes.FindAsync(id);

        if (deleteDamageType is null)
            throw new Exception("No DamageType found with that ID");

        context.DamageTypes.Remove(deleteDamageType);
        context.SaveChangesAsync();
    }
}