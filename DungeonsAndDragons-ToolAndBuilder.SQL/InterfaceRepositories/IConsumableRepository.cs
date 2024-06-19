using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IConsumableRepository : IRepository<Consumable, int>
{
    Task<Consumable> GetConsumableByName(string name);
    Task<Consumable> GetConsumableByRarity(string rarity);

    Task<IEnumerable<Consumable>> GetAllConsumablesByType(string type);
    Task<IEnumerable<Consumable>> GetManyConsumablesByType(string type, int start, int count);
    Task<IEnumerable<Consumable>> GetManyPre5EByType(string type, bool isPre5E, int start, int count);
} 