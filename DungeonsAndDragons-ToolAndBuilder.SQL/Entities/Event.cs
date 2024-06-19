namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Event : BaseEntity
{
    // Certain events/scenarios which the DM can plan out for the players to experience.
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string? EventImg { get; set; }
    public ICollection<Tag>? EventTags { get; set; }
    

}