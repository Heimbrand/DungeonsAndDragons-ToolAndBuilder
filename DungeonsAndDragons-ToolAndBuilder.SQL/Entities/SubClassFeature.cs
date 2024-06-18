namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SubClassFeature : BaseEntity
{
    public int SubClassId { get; set; }
    public string SubClassName { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}