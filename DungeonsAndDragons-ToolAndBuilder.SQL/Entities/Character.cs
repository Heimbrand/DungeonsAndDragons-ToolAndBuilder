using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Character : IEntity<int>
{
    public int Id { get; set; }
    public Guid CharacterGuid { get; set; }
    public string Name { get; set; } = default!;
    public List<Tag> CharacterTags { get; set; }

}