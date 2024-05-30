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


    public List<MonsterTrait> Traits { get; set; }
    public List<Tag> MonsterTags { get; set; }
    public AbilityScore AbilitiesScores { get; set; }
    public List<Condition> Conditions { get; set; }
    public List<DamageType> DamageTypes { get; set; }
    public Alignment Alignment { get; set; }
    public List<Sense> Senses { get; set; }
    public List<Skill> Skills { get; set; }
    public List<Reaction> Reactions { get; set; }
    public List<GameAction> Actions { get; set; }
    public List<LegendaryAction> LegendaryActions { get; set; }
    public List<Language> Languages { get; set; }
    public Type Type { get; set; }
    public Size Size { get; set; }
    public Challenge Challenge { get; set; }
    public Faction? Faction { get; set; }
}