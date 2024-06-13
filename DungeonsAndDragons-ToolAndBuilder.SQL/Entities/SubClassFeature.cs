using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SubClassFeature : IEntity<int>
{
    public int Id { get; set; }
    public int SubClassId { get; set; }
    public int LevelRequirement { get; set; }
    public string SubClassName { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}