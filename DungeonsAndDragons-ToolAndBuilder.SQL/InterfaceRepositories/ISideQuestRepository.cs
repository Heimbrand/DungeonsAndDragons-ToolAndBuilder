using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface ISideQuestRepository : IRepository<SideQuest, int>
{
    Task<IEnumerable<SideQuest>> GetSideQuestByName(string name);
    Task<IEnumerable<SideQuest>> GetSideQuestByRecommendedLevel(int RecommendedLevel);
}