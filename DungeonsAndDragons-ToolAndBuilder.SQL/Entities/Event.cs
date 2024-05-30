using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Event : IEntity<int>
{
    // Certain events/scenarios which the DM can plan out for the players to experience.

    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string? ImageUrl { get; set; }
    public List<Tag> EventTags { get; set; } 

}