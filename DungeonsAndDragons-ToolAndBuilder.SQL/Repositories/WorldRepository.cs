using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class WorldRepository : IWorldRepository
{
    public Task<World> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<World>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<World>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<World> AddAsync(World entity)
    {
        throw new NotImplementedException();
    }

    public Task<World> UpdateAsync(World entity)
    {
        throw new NotImplementedException();
    }

    public Task<World> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}