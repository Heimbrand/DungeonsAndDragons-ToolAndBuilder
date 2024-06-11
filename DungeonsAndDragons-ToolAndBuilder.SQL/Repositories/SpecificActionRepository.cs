using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SpecificActionRepository : ISpecificActionRepository
{
    public Task<SpecificAction> AddAsync(SpecificAction entity)
    {
        throw new NotImplementedException();
    }

    public Task<SpecificAction> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SpecificAction>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SpecificAction> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SpecificAction>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<SpecificAction> UpdateAsync(SpecificAction entity)
    {
        throw new NotImplementedException();
    }
}