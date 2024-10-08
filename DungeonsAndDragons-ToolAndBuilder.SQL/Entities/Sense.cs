﻿namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Sense : BaseEntity
{
    //Special senses such as BlindSight, DarkVision, TremorSense, etc. See DndBeyond for reference.
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
  
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public bool IsPre5E { get; set; } = default!;
}