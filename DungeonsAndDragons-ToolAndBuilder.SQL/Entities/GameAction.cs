using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class GameAction : IEntity<int>
{
    public int Id { get; set; }
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public int ClassActionId { get; set; }
    public int SubClassActionId { get; set; }
    public int RaceActionId { get; set; }
    public int SubRaceActionId { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
}