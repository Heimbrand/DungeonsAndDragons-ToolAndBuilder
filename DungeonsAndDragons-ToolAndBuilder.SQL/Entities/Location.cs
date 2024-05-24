﻿namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Location
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? LocationUrl { get; set; }

}