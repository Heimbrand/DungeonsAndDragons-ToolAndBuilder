namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Proficiency : BaseEntity
{
    public int CharacterId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public int SkillBonus { get; set; }
    public string? RelatedAbilityScoreBonus { get; set; } // i.e. Dexterity
    public bool IsPre5E { get; set; } = default!;
    public ProficiencyType ProficiencyType { get; set; } = default!;

}