using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class ClassAction : IEntity<int>
{
    public int Id { get; set; }
    public int ClassId { get; set; }
   public ICollection<GameAction> ClassActions { get; set; }
}