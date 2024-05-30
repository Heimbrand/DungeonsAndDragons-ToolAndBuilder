using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class RacialTraits : IEntity<int>
{
    // can be spells, immunities, proficiencies, etc.
    public int Id { get; set; }
    public int RaceId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}