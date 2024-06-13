using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class RacialTraitRepository : IRacialTraitRepository
{
    public Task<RacialTrait> AddAsync(RacialTrait entity)
    {
        throw new NotImplementedException();
    }

    public Task<RacialTrait> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RacialTrait>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<RacialTrait> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RacialTrait>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<RacialTrait> UpdateAsync(RacialTrait entity)
    {
        throw new NotImplementedException();
    }
}