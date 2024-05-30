using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Type = DungeonsAndDragons_ToolAndBuilder.Shared.Entities.Type;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class TypeRepository : ITypeRepository
{
    public Task<Type> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Type>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Type>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Type> AddAsync(Type entity)
    {
        throw new NotImplementedException();
    }

    public Task<Type> UpdateAsync(Type entity)
    {
        throw new NotImplementedException();
    }

    public Task<Type> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}