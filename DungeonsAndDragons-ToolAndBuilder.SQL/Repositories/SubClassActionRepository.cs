using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SubClassActionRepository : ISubClassActionRepository
{
    public Task<SubClassAction> AddAsync(SubClassAction entity)
    {
        throw new NotImplementedException();
    }

    public Task<SubClassAction> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SubClassAction>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SubClassAction> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SubClassAction>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<SubClassAction> UpdateAsync(SubClassAction entity)
    {
        throw new NotImplementedException();
    }
}