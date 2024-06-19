using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IConsumableRepository : IRepository<Consumable, int>
{
    Task<Consumable> GetConsumableByName(string name);
    Task<Consumable> GetConsumableByRarity(string rarity);
    Task<Consumable> GetAllPotionConsumables(string type);
    Task<Consumable> GetAllScrollConsumables(string type);
    Task<Consumable> GetAllWandConsumables(string type);
    Task<Consumable> GetAllOtherConsumables(string type);


    Task<Consumable> GetManyPotionConsumables(string type, int start, int count);
    Task<Consumable> GetManyScrollConsumables(string type, int start, int count);
    Task<Consumable> GetManyWandConsumables(string type, int start, int count); 
    Task<Consumable> GetManyOtherConsumables(string type, int start, int count);
}