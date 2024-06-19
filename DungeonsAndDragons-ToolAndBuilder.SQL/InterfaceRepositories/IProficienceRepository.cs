using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IProficienceRepository : IRepository<Proficiency, int>
{
    Task<IEnumerable<Proficiency>> GetProficiencyByName(string name);
    Task<IEnumerable<Proficiency>> GetProficiencyByType(string type);
    Task<IEnumerable<Proficiency>> GetProficiencyByCharacterId(int characterId);
    
  
    
}