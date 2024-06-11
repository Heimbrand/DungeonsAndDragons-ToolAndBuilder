using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ClassActionRepository : IClassActionRepository
{
    public Task<ClassAction> AddAsync(ClassAction entity)
    {
        throw new NotImplementedException();
    }

    public Task<ClassAction> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ClassAction>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ClassAction> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ClassAction>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<ClassAction> UpdateAsync(ClassAction entity)
    {
        throw new NotImplementedException();
    }
}