using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Armor : IEntity<int>
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public string? ArmorClass { get; set; }
    public double? Weight { get; set; }
    public string? Cost { get; set; }
    public List<Tag>? ArmorTags { get; set; }
    public Rarity? Rarity { get; set; }

}