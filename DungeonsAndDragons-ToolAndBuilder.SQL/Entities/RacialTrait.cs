using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class RacialTrait : IEntity<int>
{
    public int Id { get; set; }
    public int RaceId { get; set; }
    public string RaceName { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}