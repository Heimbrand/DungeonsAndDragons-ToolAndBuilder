using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Collections;

public abstract class BaseDocument : IEntity<ObjectId>
{
    [BsonId]
    public ObjectId Id { get; set; }
}

// This class is abstract. It is used as a baseclass for the collections, that way i know the collections will always have an ObjectId Id property.
// The same Logic is applied with my SQL database, the abstract class is called BaseEntity, you can find it in my projekt for sql.