using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SubClassAction : IEntity<int>
{
    public int Id { get; set; }
    public int SubClassId { get; set; }
    public ICollection<GameAction> SubClassActions { get; set; }
}