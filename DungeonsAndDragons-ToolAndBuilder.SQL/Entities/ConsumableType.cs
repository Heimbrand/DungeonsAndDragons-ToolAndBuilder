using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class ConsumableType : IEntity<int>
{
    public int Id { get; set; }
    public int ConsumableId { get; set; }
    public string Name { get; set; } = default!;
}