using System.ComponentModel.DataAnnotations;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class World
{
    public int Id { get; set; }
    [StringLength(50), RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
    public string Name { get; set; } 
    public string? Description { get; set; }
    public string? WorldUrl { get; set; }
    public List<Tag>? Tags { get; set; } // This is a list of tags that are used to categorize the world

    public World(int id, string name, string? description, string? worldUrl, List<Tag>? tags)
    {
        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null!");
        Description = description;
        WorldUrl = worldUrl;
        Tags = tags;
    }
}


