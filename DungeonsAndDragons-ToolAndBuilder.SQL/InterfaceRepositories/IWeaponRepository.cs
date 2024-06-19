using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IWeaponRepository : IRepository<Weapon, int>
{
    Task<Weapon> GetWeaponByName(string name);

    Task<IEnumerable<Weapon>> GetWeaponsByCharacterId(int characterId);
    Task<IEnumerable<Weapon>> GetWeaponsByType(string type);
    Task<IEnumerable<Weapon>> GetWeaponsByDamageType(string damageType);
    Task<IEnumerable<Weapon>> GetWeaponByRarity(string rarity);
}