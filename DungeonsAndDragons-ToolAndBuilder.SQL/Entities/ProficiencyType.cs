﻿namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class ProficiencyType : BaseEntity
{
    public int ProficiencyId { get; set; }
    public string Name { get; set; } = default!;
}