using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ConsumableTypeRepository : IConsumableTypeRepository
{
    public Task<ConsumableType> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ConsumableType>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ConsumableType>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<ConsumableType> AddAsync(ConsumableType entity)
    {
        throw new NotImplementedException();
    }

    public Task<ConsumableType> UpdateAsync(ConsumableType entity)
    {
        throw new NotImplementedException();
    }

    public Task<ConsumableType> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}