using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Monster : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public int? ArmorClass { get; set; }
    public int? HitPoints { get; set; }
    public string? HitDice { get; set; }
    public string? Speed { get; set; }
    public string? Description { get; set; }
    public int ChallengeRating { get; set; }
    public int ExperiencePoints { get; set; }

    public Alignment Alignment { get; set; }
    public MonsterType MonsterType { get; set; }
    public Size Size { get; set; }
    public Faction? Faction { get; set; }

    public ICollection<MonsterTrait> Traits { get; set; }
    public ICollection<Tag> MonsterTags { get; set; }
    public ICollection<Condition> Conditions { get; set; }
    public ICollection<DamageType> DamageTypes { get; set; }
    public ICollection<Sense> Senses { get; set; }
    public ICollection<Skill> Skills { get; set; }
    public ICollection<Reaction> Reactions { get; set; }
    public ICollection<GameAction> Actions { get; set; }
    public ICollection<Language> Languages { get; set; }

   
}