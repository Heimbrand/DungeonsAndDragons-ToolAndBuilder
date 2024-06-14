using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Proficiency : BaseEntity
{
    public int ClassId { get; set; }
    public int SubClassId { get; set; }
    public int RaceId { get; set; }
    public int SubRaceId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public int SkillBonus { get; set; }
    public string? RelatedAbilityScoreBonus { get; set; } // i.e. Dexterity

    public ProficiencyType ProficiencyType { get; set; }


}