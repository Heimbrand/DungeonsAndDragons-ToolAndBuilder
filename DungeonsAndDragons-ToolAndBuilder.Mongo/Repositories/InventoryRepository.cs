using DungeonsAndDragons_ToolAndBuilder.Mongo.InterfaceRepositories;
using DungeonsAndDragons_ToolAndBuilder.Shared.Collections;
using MongoDB.Bson;

namespace DungeonsAndDragons_ToolAndBuilder.Mongo.Repositories;

public class InventoryRepository : IInventoryRepository
{
    public Task<Inventory> AddAsync(Inventory entity)
    {
        throw new NotImplementedException();
    }

    public Task<Inventory> DeleteAsync(ObjectId id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Inventory>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Inventory> GetByIdAsync(ObjectId id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Inventory>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Inventory> UpdateAsync(Inventory entity)
    {
        throw new NotImplementedException();
    }
}