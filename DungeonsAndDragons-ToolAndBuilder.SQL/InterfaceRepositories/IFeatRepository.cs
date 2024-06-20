using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IFeatRepository : IRepository<Feat, int>
{
    Task<Feat> GetFeatByName(string name);
    Task<IEnumerable<Feat>> GetManyPre5EFeats(int start, int count);
    Task<IEnumerable<Feat>> GetAllPre5EFeats();
}