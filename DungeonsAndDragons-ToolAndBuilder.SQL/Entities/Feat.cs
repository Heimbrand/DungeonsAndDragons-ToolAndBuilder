﻿using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Feat : BaseEntity
{
    public int CharacterId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}