﻿using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Reaction : IEntity<int>
{
    // Reactions are special actions that can be taken outside of a characters turn.

    public int Id { get; set; }
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
}