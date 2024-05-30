namespace DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

public interface IEntity<T>
{
    T Id { get; set; }
}