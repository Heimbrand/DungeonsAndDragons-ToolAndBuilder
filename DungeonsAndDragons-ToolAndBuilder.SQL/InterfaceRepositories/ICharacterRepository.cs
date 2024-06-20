using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface ICharacterRepository : IRepository<Character, int>
{
    Task<IEnumerable<Character>> GetCharacterByName(string name);
    Task<IEnumerable<Character>> GetAllLivingCharacters();
    Task<IEnumerable<Character>> GetAllDeadCharacters();
}