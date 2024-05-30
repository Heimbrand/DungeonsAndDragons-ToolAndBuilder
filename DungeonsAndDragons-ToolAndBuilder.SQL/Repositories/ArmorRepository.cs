using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ArmorRepository : IArmorRepository
{
    public Task<Armor> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Armor>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Armor>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Armor> AddAsync(Armor entity)
    {
        throw new NotImplementedException();
    }

    public Task<Armor> UpdateAsync(Armor entity)
    {
        throw new NotImplementedException();
    }

    public Task<Armor> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}