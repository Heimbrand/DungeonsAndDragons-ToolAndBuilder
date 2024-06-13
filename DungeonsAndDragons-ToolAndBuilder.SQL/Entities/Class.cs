﻿using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Class : IEntity<int>
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? ClassImg { get; set; }

  
    public ICollection<ClassFeature>? ClassFeatures { get; set; }
    public ICollection<Proficiency>? Proficiencies { get; set; }

    
}