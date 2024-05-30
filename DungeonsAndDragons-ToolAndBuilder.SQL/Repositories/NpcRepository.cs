using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class NpcRepository : INpcRepository
{
    public Task<Npc> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Npc>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Npc>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Npc> AddAsync(Npc entity)
    {
        throw new NotImplementedException();
    }

    public Task<Npc> UpdateAsync(Npc entity)
    {
        throw new NotImplementedException();
    }

    public Task<Npc> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}