using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class MonsterTypeRepository(DnDbContext context) : IMonsterTypeRepository
{
    public async Task<MonsterType> GetByIdAsync(int id)
    {
        var monsterTypeById = await context.MonsterTypes.FindAsync(id);

        if (monsterTypeById is null)
            throw new Exception("No MonsterType found with that ID");

        return monsterTypeById;
    }

    public async Task<IEnumerable<MonsterType>> GetAllAsync()
    {
        var allMonsterTypes = await context.MonsterTypes.ToListAsync();

        if (allMonsterTypes is null)
            throw new Exception("No MonsterTypes found");

        return allMonsterTypes;
    }

    public async Task<IEnumerable<MonsterType>> GetMany(int start, int count)
    {
        var getManyMonsterTypes = await context.MonsterTypes.Skip(start).Take(count).ToListAsync();

        if (getManyMonsterTypes is null)
            throw new Exception("No MonsterTypes found");

        return getManyMonsterTypes;
    }

    public async Task AddAsync(MonsterType entity)
    {
        var addMonsterType = await context.MonsterTypes.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(MonsterType entity)
    {
        var oldMonsterType = await context.MonsterTypes.FindAsync(entity.Id);

        if (oldMonsterType is null)
            throw new Exception("No MonsterType found with that ID");

        context.Entry(oldMonsterType).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
       var monsterTypeToDelete = await context.MonsterTypes.FindAsync(id);

        if (monsterTypeToDelete is null)
            throw new Exception("No MonsterType found with that ID");

        context.MonsterTypes.Remove(monsterTypeToDelete);
        context.SaveChangesAsync();
    }
}