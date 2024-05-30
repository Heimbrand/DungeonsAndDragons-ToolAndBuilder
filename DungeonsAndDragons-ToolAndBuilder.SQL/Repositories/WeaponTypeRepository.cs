using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class WeaponTypeRepository : IWeaponTypeRepository
{
    public Task<WeaponType> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WeaponType>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WeaponType>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<WeaponType> AddAsync(WeaponType entity)
    {
        throw new NotImplementedException();
    }

    public Task<WeaponType> UpdateAsync(WeaponType entity)
    {
        throw new NotImplementedException();
    }

    public Task<WeaponType> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}