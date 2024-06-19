using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IFactionRepository : IRepository<Faction, int>
{
    Task<IEnumerable<Faction>> GetAllPre5EFactions(bool isPre5E);
    Task<Faction> GetFactionByName(string name);

}