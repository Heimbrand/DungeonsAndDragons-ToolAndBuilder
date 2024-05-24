namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Skill
{
    // What is the purpose of this class?


    public int Id { get; set; }
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public int Bonus { get; set; }
}