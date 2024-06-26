using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class CraftingRepository : ICraftingRepository
{
    public Task<Crafting> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Crafting>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Crafting>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Crafting entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Crafting entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}