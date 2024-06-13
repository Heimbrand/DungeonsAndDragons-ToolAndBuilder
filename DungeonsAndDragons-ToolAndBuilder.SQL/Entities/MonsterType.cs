using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class MonsterType : IEntity<int>
{
    public int Id { get; set; }
    public int MonsterId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }

}