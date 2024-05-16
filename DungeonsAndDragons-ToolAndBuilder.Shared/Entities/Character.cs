namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public List<Tag> CharacterTags { get; set; }

}