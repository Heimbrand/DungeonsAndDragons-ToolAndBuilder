using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SubRaceAction : IEntity<int>
{
    public int Id { get; set; }
    public int SubRaceId { get; set; }
    public ICollection<GameAction> SubRaceActions { get; set; }
}