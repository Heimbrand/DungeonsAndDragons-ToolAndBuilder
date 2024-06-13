using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class MiscellaneousItem : IEntity<int>
{
    public int Id { get; set; }
    public Guid MiscellaneousItemGuid { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public double? Weight { get; set; }
    

}