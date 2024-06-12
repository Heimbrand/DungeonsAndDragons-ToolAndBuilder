using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class GameActionTypeRepository : IGameActionTypeRepository
{
    public Task<GameActionType> AddAsync(GameActionType entity)
    {
        throw new NotImplementedException();
    }

    public Task<GameActionType> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GameActionType>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GameActionType> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GameActionType>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<GameActionType> UpdateAsync(GameActionType entity)
    {
        throw new NotImplementedException();
    }
}