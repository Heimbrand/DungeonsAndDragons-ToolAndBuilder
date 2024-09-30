namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Character : BaseEntity
{
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
    public bool? IsDead { get; set; }
    public bool IsPre5E { get; set; } = default!;


    public int? Strength { get; set; }
    public int? Dexterity { get; set; }
    public int? Constitution { get; set; }
    public int? Intelligence { get; set; }
    public int? Wisdom { get; set; }
    public int? Charisma { get; set; }

    public Journal? Journal { get; set; }
    public Race? Race { get; set; }
    public SubRace? SubRace { get; set; }
    public Class? Class { get; set; } = default!;
    public SubClass? SubClass { get; set; }

    public Alignment? Alignment { get; set; }
    public Size? Size { get; set; } // Better suited as an enum perhaps?
    public Faction? Faction { get; set; }

    public ICollection<Proficiency> Proficiencies { get; set; } = new List<Proficiency>();
    public ICollection<Feat>? Feats { get; set; } = new List<Feat>();
    public ICollection<Condition>? Conditions { get; set; } = new List<Condition>(); //poisoned, paralyzed, immunities, etc
    public ICollection<Language>? Languages { get; set; } = new List<Language>();
    public ICollection<Skill>? Skills { get; set; } = new List<Skill>();
    public ICollection<Sense>? Senses { get; set; } = new List<Sense>();
    public ICollection<DamageType>? DamageTypes { get; set; } = new List<DamageType>(); //resistances, immunities, vulnerabilities
    public ICollection<Reaction>? Reactions { get; set; } = new List<Reaction>();
    public ICollection<GameAction>? Actions { get; set; } = new List<GameAction>();
}

