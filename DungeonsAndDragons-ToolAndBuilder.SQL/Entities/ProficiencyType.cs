using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class ProficiencyType : IEntity<int>
{
    public int Id { get; set; }
    public int ProficiencyId { get; set; }
    public string Name { get; set; } = default!;
}