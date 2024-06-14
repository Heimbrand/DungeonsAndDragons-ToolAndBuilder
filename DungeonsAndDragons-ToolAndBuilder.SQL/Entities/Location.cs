using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Location : BaseEntity
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? LocationUrl { get; set; }

}