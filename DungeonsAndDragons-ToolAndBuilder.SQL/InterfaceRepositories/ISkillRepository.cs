using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface ISkillRepository : IRepository<Skill, int>
{
    Task<IEnumerable<Skill>> GetSkillsByCharacterId(int characterId);
}