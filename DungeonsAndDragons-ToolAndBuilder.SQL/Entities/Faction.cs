﻿namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Faction
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public int MonsterId { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string? ImageUrl { get; set; }

}