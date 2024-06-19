using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface INpcRepository : IRepository<Npc, int>
{
    Task<IEnumerable<Npc>> GetNpcByName(string name);
    Task<IEnumerable<Npc>> GetAllLivingNpcs(bool isDead);
    Task<IEnumerable<Npc>> GetAllDeadNpcs(bool isdead);
}