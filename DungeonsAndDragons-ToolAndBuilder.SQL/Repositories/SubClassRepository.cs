using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SubClassRepository : ISubClassRepository
{
    public Task<SubClass> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SubClass>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SubClass>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<SubClass> AddAsync(SubClass entity)
    {
        throw new NotImplementedException();
    }

    public Task<SubClass> UpdateAsync(SubClass entity)
    {
        throw new NotImplementedException();
    }

    public Task<SubClass> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}