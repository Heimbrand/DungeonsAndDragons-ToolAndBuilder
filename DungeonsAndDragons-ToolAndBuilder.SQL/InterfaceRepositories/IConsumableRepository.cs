using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IConsumableRepository : IRepository<Consumable, int>
{
    Task<IEnumerable<Consumable>> GetConsumableByName(string name);
    Task<IEnumerable<Consumable>> GetConsumablesByRarity(string rarity);

    Task<IEnumerable<Consumable>> GetAllConsumablesByType(string type);
    Task<IEnumerable<Consumable>> GetManyConsumablesByType(string type, int start, int count);
    Task<IEnumerable<Consumable>> GetManyPre5EByType(string type,int start, int count);
} 