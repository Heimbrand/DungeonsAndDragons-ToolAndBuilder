using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Feat : IEntity<int>
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public string Name { get; set; } = default!;
    public string Prerequisite { get; set; } = default!;
    public string? Description { get; set; }
}