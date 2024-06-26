using DungeonsAndDragons_ToolAndBuilder.Shared.Collections;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;
using MongoDB.Bson;

namespace DungeonsAndDragons_ToolAndBuilder.Mongo.InterfaceRepositories;

public interface IInventoryRepository : IRepository<Inventory, ObjectId>
{ 
    public Task<IEnumerable<Inventory>> GetInventoryByCharacterGuid(ObjectId characterGuid);

}