using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class RacialTraitsRepository : IRacialTraitsRepository
{
    public Task<RacialTraits> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RacialTraits>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RacialTraits>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<RacialTraits> AddAsync(RacialTraits entity)
    {
        throw new NotImplementedException();
    }

    public Task<RacialTraits> UpdateAsync(RacialTraits entity)
    {
        throw new NotImplementedException();
    }

    public Task<RacialTraits> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}