using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class DamageTypeRepository : IDamageTypeRepository
{
    public Task<DamageType> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DamageType>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DamageType>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<DamageType> AddAsync(DamageType entity)
    {
        throw new NotImplementedException();
    }

    public Task<DamageType> UpdateAsync(DamageType entity)
    {
        throw new NotImplementedException();
    }

    public Task<DamageType> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}