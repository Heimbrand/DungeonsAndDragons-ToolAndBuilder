namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Consumable
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Effect { get; set; } = default!;
    public string? ImageUrl { get; set; }
    public int Weight { get; set; }
    public double Cost { get; set; }
    public Rarity Rarity { get; set; }
    public List<Tag>? ConsumableTags { get; set; }
    public ConsumableType ConsumableType { get; set; }


}