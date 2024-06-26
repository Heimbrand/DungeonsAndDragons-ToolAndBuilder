namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class DamageType : BaseEntity
{
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!; //Fire Resistance, Cold Immunity, Fire Vulnerability etc
    public string Description { get; set; } = default!;
   
    public bool IsPre5E { get; set; } = default!;

}