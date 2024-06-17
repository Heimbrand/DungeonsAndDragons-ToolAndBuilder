using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Npc : BaseEntity
{
    public Guid NpcGuid { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public int? ArmorClass { get; set; }

    public int? Strength { get; set; }
    public int? Dexterity { get; set; }
    public int? Constitution { get; set; }
    public int? Intelligence { get; set; }
    public int? Wisdom { get; set; }
    public int? Charisma { get; set; }

    public Race Race { get; set; } = default!;
    public SubRace? SubRace { get; set; }
    public Class Class { get; set; } = default!;
    public SubClass? SubClass { get; set; }

  
    public Alignment? Alignment { get; set; }
    public Size? Size { get; set; }
    public Faction? Faction { get; set; }

    public ICollection<Tag> NpcTags { get; set; }
    public ICollection<Condition> Conditions { get; set; } //poisoned, paralyzed, etc
    public ICollection<Language> Languages { get; set; }
    public ICollection<Skill> Skills { get; set; }
    public ICollection<Sense> Senses { get; set; } //darkvision, blindsight, etc
    public ICollection<DamageType> DamageTypes { get; set; } //resistances, immunities, vulnerabilities
    public ICollection<Reaction> Reactions { get; set; }
    public ICollection<GameAction> Actions { get; set; } // default actions, the class and race will add more


}   