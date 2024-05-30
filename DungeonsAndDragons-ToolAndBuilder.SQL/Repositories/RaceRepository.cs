using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class RaceRepository : IRaceRepository
{
    public Task<Race> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Race>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Race>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Race> AddAsync(Race entity)
    {
        throw new NotImplementedException();
    }

    public Task<Race> UpdateAsync(Race entity)
    {
        throw new NotImplementedException();
    }

    public Task<Race> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}