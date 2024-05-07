using DungeonsAndDragons_ToolAndBuilder.Shared.Collections;
using MongoDB.Driver;

namespace DungeonsAndDragons_ToolAndBuilder.Mongo.Repositories;

public class InventoryRepository
{
    private readonly IMongoCollection<Inventory> _inventory;
    public InventoryRepository()
    {
        var hostName = "localhost";
        var port = "27017";
        var dataBaseName = "DungeonsAndDragonsToolAndBuilder";
        var collectionName = "Inventory";
        var client = new MongoClient($"mongoDb://{hostName}:{port}");
        var database = client.GetDatabase(dataBaseName);
        _inventory = database.GetCollection<Inventory>(collectionName, new MongoCollectionSettings(){AssignIdOnInsert = true});
    }
    
}