namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class ClassFeature : BaseEntity
{
    public int ClassId { get; set; }
    public int LevelRequirement { get; set; }
    public string ClassName { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public bool IsPre5E { get; set; } = default!;

}