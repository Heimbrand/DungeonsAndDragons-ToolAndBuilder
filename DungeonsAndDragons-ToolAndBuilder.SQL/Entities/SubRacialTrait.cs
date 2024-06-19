namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SubRacialTrait : BaseEntity
{
    public int SubRaceId { get; set; }
    public string SubRaceName { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public bool IsPre5E { get; set; } = default!;
}