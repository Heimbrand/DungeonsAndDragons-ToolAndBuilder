using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class FactionRepository : IFactionRepository
{
    public Task<Faction> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Faction>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Faction>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Faction> AddAsync(Faction entity)
    {
        throw new NotImplementedException();
    }

    public Task<Faction> UpdateAsync(Faction entity)
    {
        throw new NotImplementedException();
    }

    public Task<Faction> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}