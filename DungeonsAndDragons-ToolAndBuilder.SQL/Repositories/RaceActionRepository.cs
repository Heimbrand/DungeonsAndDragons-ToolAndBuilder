using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class RaceActionRepository : IRaceActionRepository
{
    public Task<RaceAction> AddAsync(RaceAction entity)
    {
        throw new NotImplementedException();
    }

    public Task<RaceAction> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RaceAction>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<RaceAction> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RaceAction>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<RaceAction> UpdateAsync(RaceAction entity)
    {
        throw new NotImplementedException();
    }
}