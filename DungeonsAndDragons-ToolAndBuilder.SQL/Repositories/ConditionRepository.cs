using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ConditionRepository : IConditionRepository
{
    public Task<Condition> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Condition>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Condition>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Condition> AddAsync(Condition entity)
    {
        throw new NotImplementedException();
    }

    public Task<Condition> UpdateAsync(Condition entity)
    {
        throw new NotImplementedException();
    }

    public Task<Condition> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}