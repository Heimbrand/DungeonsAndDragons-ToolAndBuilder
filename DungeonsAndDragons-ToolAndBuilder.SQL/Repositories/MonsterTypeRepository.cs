using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class MonsterTypeRepository : IMonsterTypeRepository
{
    public Task<MonsterType> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MonsterType>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MonsterType>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<MonsterType> AddAsync(MonsterType entity)
    {
        throw new NotImplementedException();
    }

    public Task<MonsterType> UpdateAsync(MonsterType entity)
    {
        throw new NotImplementedException();
    }

    public Task<MonsterType> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}