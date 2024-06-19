using DungeonsAndDragons_ToolAndBuilder.Mongo.InterfaceRepositories;
using DungeonsAndDragons_ToolAndBuilder.Shared.Collections;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DungeonsAndDragons_ToolAndBuilder.Mongo.Repositories;

public class InventoryRepository : IInventoryRepository
{
    private readonly IMongoCollection<Inventory> _inventoryCollection;
    public InventoryRepository()
    {
        var hostName = "localhost";
        var port = "27017";
        var databaseName = "DnD";
        var collectionName = "Inventory";
        var client = new MongoClient($"mongodb://{hostName}:{port}");
        var database = client.GetDatabase(databaseName);
        _inventoryCollection = database.GetCollection<Inventory>(collectionName, new MongoCollectionSettings(){AssignIdOnInsert = true});
    }
    public Task AddAsync(Inventory entity)
    {
        throw new NotImplementedException();
    }
    public Task DeleteAsync(ObjectId id)
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
    public Task UpdateAsync(Inventory entity)
    {
        throw new NotImplementedException();
    }
}