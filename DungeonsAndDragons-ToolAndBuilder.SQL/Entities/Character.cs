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

    public Race Race { get; set; }
    public SubRace? SubRace { get; set; }
    public Class Class { get; set; } = default!;
    public SubClass? SubClass { get; set; }

    public AbilityScore AbilitiesScores { get; set; }
    public Alignment Alignment { get; set; }
    public Size Size { get; set; }
    public Faction? Faction { get; set; }

    public List<Tag> CharacterTags { get; set; }
    public List<Condition> Conditions { get; set; }
    public List<Language> Languages { get; set; }
    public List<Skill> Skills { get; set; }
    public List<Sense> Senses { get; set; }
    public List<DamageType> DamageTypes { get; set; }
    public List<Reaction> Reactions { get; set; }
    public List<GameAction> Actions { get; set; }
    public List<LegendaryAction> LegendaryActions { get; set; }

}

