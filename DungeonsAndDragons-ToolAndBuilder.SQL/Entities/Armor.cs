using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Armor : IEntity<int>
{
    public int Id { get; set; }
    public Guid ArmorGuid { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public int ArmorClass { get; set; }
    public double? Weight { get; set; }
    public string? Cost { get; set; }
    public List<Tag>? ArmorTags { get; set; }
    public Rarity? Rarity { get; set; }

}