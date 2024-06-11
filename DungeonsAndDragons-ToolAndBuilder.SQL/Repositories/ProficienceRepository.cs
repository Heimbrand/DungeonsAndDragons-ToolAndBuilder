using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ProficienceRepository : IProficienceRepository
{
    public Task<Proficience> AddAsync(Proficience entity)
    {
        throw new NotImplementedException();
    }

    public Task<Proficience> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Proficience>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Proficience> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Proficience>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Proficience> UpdateAsync(Proficience entity)
    {
        throw new NotImplementedException();
    }
}