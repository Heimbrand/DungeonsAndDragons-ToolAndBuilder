using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class WeaponRepository : IWeaponRepository
{
    public Task<Weapon> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Weapon>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Weapon>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Weapon> AddAsync(Weapon entity)
    {
        throw new NotImplementedException();
    }

    public Task<Weapon> UpdateAsync(Weapon entity)
    {
        throw new NotImplementedException();
    }

    public Task<Weapon> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}