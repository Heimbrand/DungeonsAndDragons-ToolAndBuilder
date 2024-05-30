using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class LocationRepository : ILocationRepository
{
    public Task<Location> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Location>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Location>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Location> AddAsync(Location entity)
    {
        throw new NotImplementedException();
    }

    public Task<Location> UpdateAsync(Location entity)
    {
        throw new NotImplementedException();
    }

    public Task<Location> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}