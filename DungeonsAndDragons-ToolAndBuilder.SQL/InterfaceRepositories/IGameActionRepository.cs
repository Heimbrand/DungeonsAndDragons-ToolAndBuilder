using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IGameActionRepository : IRepository<GameAction, int>
{
    Task<IEnumerable<GameAction>> GetGameActionByName(string name);
    Task<IEnumerable<GameAction>> GetGameActionsByCharacterId(int characterId);
   
    Task<IEnumerable<GameAction>> GetManyPre5EGameActions(int start, int count);
}