using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IArmorRepository : IRepository<Armor, int>
{
    Task<IEnumerable<Armor>> GetArmorByName(string name);
    Task<IEnumerable<Armor>> GetArmorByRarity(string rarity);
    Task<IEnumerable<Armor>> GetManyPre5EArmor(bool isPre5E, int start, int count);

}