using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Crafting : IEntity<int>
{ 
    // Unclear if this will be used, but it's here just in case.

    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public ICollection<Tag> Tags { get; set; }

}