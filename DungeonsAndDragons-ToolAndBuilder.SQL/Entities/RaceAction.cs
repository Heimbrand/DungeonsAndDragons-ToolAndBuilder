using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class RaceAction : IEntity<int>
{
    public int Id { get; set; }
    public int RaceId { get; set; }
    public ICollection<GameAction> RaceActions { get; set; }
}