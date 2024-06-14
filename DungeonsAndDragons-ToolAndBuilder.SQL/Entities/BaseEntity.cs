using System.ComponentModel.DataAnnotations;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class BaseEntity : IEntity<int>
{
    [Key]
    public int Id { get; set; }
}

// This class is abstract. It is used as a baseclass for the entities, that way i know the entities will always have an int Id property.