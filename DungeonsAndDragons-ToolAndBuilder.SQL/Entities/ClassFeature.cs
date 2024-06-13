using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class ClassFeature : IEntity<int>
{
    public int Id { get; set; }
    public int ClassId { get; set; }
    public int LevelRequirement { get; set; }
    public string ClassName { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }

}