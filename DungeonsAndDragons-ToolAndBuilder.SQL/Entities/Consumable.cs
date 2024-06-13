﻿using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Consumable : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Effect { get; set; } = default!;
    public string? ImageUrl { get; set; }
    public int Weight { get; set; }
    public double? Cost { get; set; }
    public string? Rarity { get; set; }
    public string? ConsumableType { get; set; } // Potion, Scroll, Wand, etc.

}