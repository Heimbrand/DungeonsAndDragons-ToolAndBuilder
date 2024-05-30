using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class WeaponPropertyRepository : IWeaponPropertyRepository
{
    public Task<WeaponProperty> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WeaponProperty>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WeaponProperty>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<WeaponProperty> AddAsync(WeaponProperty entity)
    {
        throw new NotImplementedException();
    }

    public Task<WeaponProperty> UpdateAsync(WeaponProperty entity)
    {
        throw new NotImplementedException();
    }

    public Task<WeaponProperty> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}