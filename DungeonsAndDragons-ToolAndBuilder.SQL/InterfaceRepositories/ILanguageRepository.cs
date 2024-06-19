using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface ILanguageRepository : IRepository<Language, int>
{
    Task<IEnumerable<Language>> GetLanguagesByNpcId(int NpcId);
    Task<IEnumerable<Language>> GetLanguagesByCharacterId(int characterId);
}