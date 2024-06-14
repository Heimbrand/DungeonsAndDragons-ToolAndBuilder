using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Alignment : BaseEntity
{
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }

    public string Name { get; set; } = default!;
    public string? Description { get; set; } 
}