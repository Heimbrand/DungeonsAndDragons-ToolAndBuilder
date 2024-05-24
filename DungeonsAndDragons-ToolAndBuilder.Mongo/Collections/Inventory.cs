using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using MongoDB.Bson;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Collections;

public class Inventory
{
    public ObjectId Id { get; set; }
    public Guid CharacterId { get; set; }
    public Guid NpcId { get; set; }

}