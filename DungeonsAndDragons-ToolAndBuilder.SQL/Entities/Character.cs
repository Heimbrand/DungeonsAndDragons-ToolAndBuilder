using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Character : IEntity<int>
{
    public int Id { get; set; }
    public Guid CharacterGuid { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? CharacterImg { get; set; }
    public int? ArmorClass { get; set; }
    public int? Initiative { get; set; }
    public int? Level { get; set; }
    public int? Experience { get; set; }
    public string? Speed { get; set; }
    public int? ProficiencyBonus { get; set; }
    public int? CurrentHitPoints { get; set; }
    public int? HitPointsMax { get; set; }
    public int? TemporaryHitPoints { get; set; }
    public string? HitDice { get; set; }
    public int? DeathSaveSuccesses { get; set; }
    public int? DeathSaveFailures { get; set; }
    

    public int? Strength { get; set; }
    public int? Dexterity { get; set; }
    public int? Constitution { get; set; }
    public int? Intelligence { get; set; }
    public int? Wisdom { get; set; }
    public int? Charisma { get; set; }

    public Race? Race { get; set; }
    public SubRace? SubRace { get; set; }
    public Class? Class { get; set; } = default!;
    public SubClass? SubClass { get; set; }

    public Alignment? Alignment { get; set; }
    public Size? Size { get; set; }
    public Faction? Faction { get; set; }

    public ICollection<Tag>? CharacterTags { get; set; }
    public ICollection<Feat>? Feats { get; set; }
    public ICollection<Condition>? Conditions { get; set; } //poisoned, paralyzed, immunities, etc
    public ICollection<Language>? Languages { get; set; }
    public ICollection<Skill>? Skills { get; set; }
    public ICollection<Sense>? Senses { get; set; }
    public ICollection<DamageType>? DamageTypes { get; set; } //resistances, immunities, vulnerabilities
    public ICollection<Reaction>? Reactions { get; set; }
    public ICollection<GameAction>? Actions { get; set; } 


}

