using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class FeatRepository : IFeatRepository
{
    public Task<Feat> AddAsync(Feat entity)
    {
        throw new NotImplementedException();
    }

    public Task<Feat> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Feat>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Feat> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Feat>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Feat> UpdateAsync(Feat entity)
    {
        throw new NotImplementedException();
    }
}