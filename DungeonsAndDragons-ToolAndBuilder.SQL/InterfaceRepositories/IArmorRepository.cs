using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IArmorRepository : IRepository<Armor, int>
{
    Task<Armor> GetArmorByName(string name);
    Task<Armor> GetArmorByRarity(string rarity);
}