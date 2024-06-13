using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SubRacialTrait : IEntity<int>
{
    public int Id { get; set; }
    public int SubRaceId { get; set; }
    public string SubRaceName { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}