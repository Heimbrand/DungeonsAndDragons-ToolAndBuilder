using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Type : IEntity<int>
{
    public int Id { get; set; }
    public int MonsterId { get; set; }

}