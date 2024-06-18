namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Consumable : BaseEntity
{
    public Guid ConsumableGuid { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Effect { get; set; } = default!;
    public string? ImageUrl { get; set; }
    public double Weight { get; set; }
    public double? Cost { get; set; }
    public string? Rarity { get; set; }
    public string? ConsumableType { get; set; } // Potion, Scroll, Wand, etc.

}