using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ClassRepository : IClassRepository
{
    public Task<Class> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Class>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Class>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Class> AddAsync(Class entity)
    {
        throw new NotImplementedException();
    }

    public Task<Class> UpdateAsync(Class entity)
    {
        throw new NotImplementedException();
    }

    public Task<Class> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}