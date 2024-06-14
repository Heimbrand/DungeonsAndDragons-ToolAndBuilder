﻿using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SubClass : BaseEntity
{
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? SubClassImg { get; set; }

    
   
    public ICollection<SubClassFeature>? SubClassFeatures { get; set; }
    public ICollection<Proficiency>? Proficiencies { get; set; }
    


}