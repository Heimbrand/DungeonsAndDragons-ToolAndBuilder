using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface INpcRepository : IRepository<Npc, int>
{
    Task<IEnumerable<Npc>> GetNpcByName(string name);
    Task<IEnumerable<Npc>> GetAllLivingNpcs();
    Task<IEnumerable<Npc>> GetAllDeadNpcs();
}