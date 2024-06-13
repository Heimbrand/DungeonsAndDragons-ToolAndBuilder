using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SubRacialTraitRepository : ISubRacialTraitRepository
{
    public Task<SubRacialTrait> AddAsync(SubRacialTrait entity)
    {
        throw new NotImplementedException();
    }

    public Task<SubRacialTrait> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SubRacialTrait>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SubRacialTrait> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SubRacialTrait>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<SubRacialTrait> UpdateAsync(SubRacialTrait entity)
    {
        throw new NotImplementedException();
    }
}