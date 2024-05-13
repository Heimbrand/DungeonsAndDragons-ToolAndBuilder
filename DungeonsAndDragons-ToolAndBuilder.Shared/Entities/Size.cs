﻿namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Size
{
    public int Id { get; set; }
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }  
    public string Name { get; set; } = default!;
}