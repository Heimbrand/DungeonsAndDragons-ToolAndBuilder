using DungeonsAndDragons_ToolAndBuilder.Shared.Collections;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;
using MongoDB.Bson;

namespace DungeonsAndDragons_ToolAndBuilder.Mongo.InterfaceRepositories;

public interface IInventoryRepository : IRepository<Inventory, ObjectId>
{
    public Task AddAsync(Inventory entity);
    public Task DeleteAsync(ObjectId id);
    public Task<IEnumerable<Inventory>> GetAllAsync();
    public Task<Inventory> GetByIdAsync(ObjectId id);
    public Task<IEnumerable<Inventory>> GetMany(int start, int count);
    public Task UpdateAsync(Inventory entity);
    public Task<IEnumerable<Inventory>> GetByCharacterGuidAsync(ObjectId characterGuid);
    

}