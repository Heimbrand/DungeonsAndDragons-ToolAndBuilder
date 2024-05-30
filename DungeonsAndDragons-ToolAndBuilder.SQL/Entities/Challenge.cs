using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Challenge : IEntity<int>
{
    public int Id { get; set; }
    public int MonsterId { get; set; }
    public int ChallengeRating { get; set; }
    public int ExperiencePoints { get; set; }
}