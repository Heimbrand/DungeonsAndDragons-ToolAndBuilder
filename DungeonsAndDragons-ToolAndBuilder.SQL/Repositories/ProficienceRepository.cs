using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ProficienceRepository : IProficienceRepository
{
    public Task<Proficiency> AddAsync(Proficiency entity)
    {
        throw new NotImplementedException();
    }

    public Task<Proficiency> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Proficiency>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Proficiency> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Proficiency>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Proficiency> UpdateAsync(Proficiency entity)
    {
        throw new NotImplementedException();
    }
}