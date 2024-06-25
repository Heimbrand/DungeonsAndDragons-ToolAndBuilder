using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class MonsterTraitRepository(DnDbContext context) : IMonsterTraitRepository
{
    public async Task<MonsterTrait> GetByIdAsync(int id)
    {
        var monsterTraitById = await context.MonsterTraits.FindAsync(id);

        if (monsterTraitById is null)
            throw new Exception("No MonsterTrait found with that ID");

        return monsterTraitById;
    }

    public async Task<IEnumerable<MonsterTrait>> GetAllAsync()
    {
        var allMonsterTraits = await context.MonsterTraits.ToListAsync();

        if (allMonsterTraits is null)
            throw new Exception("No MonsterTraits found");

        return allMonsterTraits;
    }

    public async Task<IEnumerable<MonsterTrait>> GetMany(int start, int count)
    {
        var getManyMonsterTraits = await context.MonsterTraits.Skip(start).Take(count).ToListAsync();

        if (getManyMonsterTraits is null)
            throw new Exception("No MonsterTraits found");

        return getManyMonsterTraits;
    }

    public async Task AddAsync(MonsterTrait entity)
    {
        var addMonsterTrait = await context.MonsterTraits.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(MonsterTrait entity)
    {
        var oldMonstertrait = await context.MonsterTraits.FindAsync(entity.Id);

        if (oldMonstertrait is null)
            throw new Exception("No MonsterTrait found with that ID");

        context.Entry(oldMonstertrait).CurrentValues.SetValues(entity);
    }

    public async Task DeleteAsync(int id)
    {
        var monsterTraitToDelete = await context.MonsterTraits.FindAsync(id);

        if (monsterTraitToDelete is null)
            throw new Exception("No MonsterTrait found with that ID");

        context.MonsterTraits.Remove(monsterTraitToDelete);
    }
}