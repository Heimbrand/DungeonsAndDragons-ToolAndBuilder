using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SubRaceRepository : ISubRaceRepository
{
    public Task<SubRace> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SubRace>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SubRace>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<SubRace> AddAsync(SubRace entity)
    {
        throw new NotImplementedException();
    }

    public Task<SubRace> UpdateAsync(SubRace entity)
    {
        throw new NotImplementedException();
    }

    public Task<SubRace> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}