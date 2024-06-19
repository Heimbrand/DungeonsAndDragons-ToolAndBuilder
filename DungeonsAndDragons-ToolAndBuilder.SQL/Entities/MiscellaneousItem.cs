namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class MiscellaneousItem : BaseEntity
{
    public Guid MiscellaneousItemGuid { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public double? Weight { get; set; }
    public bool IsPre5E { get; set; } = default!;


}