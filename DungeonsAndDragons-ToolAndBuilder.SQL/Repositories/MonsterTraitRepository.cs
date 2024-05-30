using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class MonsterTraitRepository : IMonsterTraitRepository
{
    public Task<MonsterTrait> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MonsterTrait>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MonsterTrait>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<MonsterTrait> AddAsync(MonsterTrait entity)
    {
        throw new NotImplementedException();
    }

    public Task<MonsterTrait> UpdateAsync(MonsterTrait entity)
    {
        throw new NotImplementedException();
    }

    public Task<MonsterTrait> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}