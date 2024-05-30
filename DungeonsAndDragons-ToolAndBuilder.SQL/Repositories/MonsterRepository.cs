using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class MonsterRepository : IMonsterRepository
{
    public Task<Monster> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Monster>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Monster>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Monster> AddAsync(Monster entity)
    {
        throw new NotImplementedException();
    }

    public Task<Monster> UpdateAsync(Monster entity)
    {
        throw new NotImplementedException();
    }

    public Task<Monster> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}