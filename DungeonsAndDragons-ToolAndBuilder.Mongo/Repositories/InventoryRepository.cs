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
    public async Task AddAsync(Inventory entity)
    {
        await _inventoryCollection.InsertOneAsync(entity);
    }
    public async Task DeleteAsync(ObjectId id)
    {
        await _inventoryCollection.DeleteOneAsync(x => x.Id == id);
    }
    public async Task<IEnumerable<Inventory>> GetAllAsync()
    {
        var filter = Builders<Inventory>.Filter.Empty;

        if (filter is null)
            throw new Exception("No inventories found");

        return await _inventoryCollection.Find(filter).ToListAsync();
    }
    public async Task<Inventory> GetByIdAsync(ObjectId id)
    {
        var filter = Builders<Inventory>.Filter.Eq(x => x.Id, id);

        if (filter is null)
            throw new Exception("No inventory found");

        return await _inventoryCollection.Find(filter).FirstOrDefaultAsync();

    }
    public async Task<IEnumerable<Inventory>> GetMany(int start, int count)
    {
       var filter = Builders<Inventory>.Filter.Empty;

        if (filter is null)
            throw new Exception("No inventories found");

        return await _inventoryCollection.Find(filter).Skip(start).Limit(count).ToListAsync();
    }
    public async Task UpdateAsync(Inventory entity)
    {
        var filter = Builders<Inventory>.Filter.Eq(x => x.Id, entity.Id);

        if (filter is null)
            throw new Exception("No inventory found");

        await _inventoryCollection.ReplaceOneAsync(filter, entity);
    }
    public async Task<IEnumerable<Inventory>> GetInventoryByCharacterGuid(ObjectId characterGuid)
    {
        var filter = Builders<Inventory>.Filter.Eq(x => x.CharacterGuid, characterGuid);

        if (filter is null)
            throw new Exception("No inventory found");

        return await _inventoryCollection.Find(filter).ToListAsync();
    }
}