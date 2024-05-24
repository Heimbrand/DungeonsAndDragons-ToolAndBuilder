using DungeonsAndDragons_ToolAndBuilder.Mongo.InterfaceRepos;
using DungeonsAndDragons_ToolAndBuilder.Shared.Collections;
using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DungeonsAndDragons_ToolAndBuilder.Mongo.Repositories;

public class InventoryRepository : IInventoryRepository
{

    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<Inventory> _productsCollection;
    private readonly IUnitOfWork _unitOfWork;

    public InventoryRepository(IUnitOfWork unitOfWork)
    {

        _unitOfWork = unitOfWork;

        var dataBaseName = "DungeonsAndDragonsToolAndBuilder";
        var collectionName = "Inventory";
        var client = new MongoClient("mongodb://localhost:27017");
        _database = client.GetDatabase(dataBaseName);
        _productsCollection = _database.GetCollection<Inventory>(collectionName, new MongoCollectionSettings() { AssignIdOnInsert = true });
    }
    public Task<Inventory> AddAsync(Inventory entity)
    {
        Action operation = () =>
        {
            _productsCollection.InsertOne(_unitOfWork.Session as IClientSessionHandle, entity);
        };
        _unitOfWork.AddOperation(operation);
        return Task.FromResult(entity);

    }
    public Task<List<Inventory>> GetAllAsync()
    {
        Action operation = () =>
        {
            _productsCollection.Find(_unitOfWork.Session as IClientSessionHandle, _ => true).ToList();
        };
        _unitOfWork.AddOperation(operation);
        return Task.FromResult(new List<Inventory>());
    }
    public Task<Inventory> UpdateAsync(Inventory entity)
    {
        Action operation = () =>
        {
            _productsCollection.ReplaceOne(_unitOfWork.Session as IClientSessionHandle, x => x.Id == entity.Id, entity);
        };
        _unitOfWork.AddOperation(operation);
        return Task.FromResult(entity);
    }
    public Task<Inventory> DeleteAsync(ObjectId id)
    {
        Action operation = () =>
        {
            _productsCollection.DeleteOne(_unitOfWork.Session as IClientSessionHandle, x => x.Id == id);
        };
        _unitOfWork.AddOperation(operation);
        return Task.FromResult(new Inventory());
    }
    public Task<Inventory> GetByCharacterIdAsync(Character characterId)
    {
        throw new NotImplementedException();
    }
    public Task GetByIdAsync<T>(ObjectId id)
    {
        throw new NotImplementedException();
    }
    public Task<Inventory> GetByNpcIdAsync(Npc npcId)
    {
        throw new NotImplementedException();
    }


}