using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface ICharacterRepository : IRepository<Character, int>
{
    Task<Character> GetCharacterByName(string name);
    Task<Character> GetAllLivingCharacters(bool isDead);
}