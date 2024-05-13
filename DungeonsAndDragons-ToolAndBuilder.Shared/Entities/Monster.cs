namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Monster
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public int ArmorClass { get; set; }
    public int HitPoints { get; set; }
    public string HitDice { get; set; }
    public string Speed { get; set; }
    public string Description { get; set; }


    public List<Trait> Traits { get; set; } 
    public List<Ability> Abilities { get; set; }
    public List<Ability> SavingThrows { get; set; }
    public List<Condition> ConditionImmunities { get; set; }
    public List<DamageType> DamageVulnerabilities { get; set; }
    public List<DamageType> DamageResistances { get; set; }
    public List<DamageType> DamageImmunities { get; set; }
    public List<Alignment> Alignments { get; set; }
    public List<Sense> Senses { get; set; }
    public List<Skill> Skills { get; set; }
    public List<Reaction> Reactions { get; set; }
    public List<GameAction> Actions { get; set; }
    public List<LegendaryActions> LegendaryActions { get; set; }
    public List<Tag> Tags { get; set; }
    public List<Language> Languages { get; set; }

    public Type Type { get; set; }
    public Size Size { get; set; }
    public Challenge Challenge { get; set; }
}