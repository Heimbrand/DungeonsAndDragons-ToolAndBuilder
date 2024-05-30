using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class GameActionRepository : IGameActionRepository
{
    public Task<GameAction> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GameAction>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GameAction>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<GameAction> AddAsync(GameAction entity)
    {
        throw new NotImplementedException();
    }

    public Task<GameAction> UpdateAsync(GameAction entity)
    {
        throw new NotImplementedException();
    }

    public Task<GameAction> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}