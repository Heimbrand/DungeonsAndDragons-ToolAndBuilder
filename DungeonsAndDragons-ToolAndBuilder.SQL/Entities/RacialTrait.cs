using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class RacialTrait : BaseEntity
{
    public int RaceId { get; set; }
    public string RaceName { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}