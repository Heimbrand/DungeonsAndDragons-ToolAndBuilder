using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class MiscellaneousItemRepository : IMiscellaneousItemRepository
{
    public Task<MiscellaneousItem> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MiscellaneousItem>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MiscellaneousItem>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<MiscellaneousItem> AddAsync(MiscellaneousItem entity)
    {
        throw new NotImplementedException();
    }

    public Task<MiscellaneousItem> UpdateAsync(MiscellaneousItem entity)
    {
        throw new NotImplementedException();
    }

    public Task<MiscellaneousItem> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}