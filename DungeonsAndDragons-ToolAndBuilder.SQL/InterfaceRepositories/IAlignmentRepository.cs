using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IAlignmentRepository : IRepository<Alignment, int>
{
    Task<Alignment> GetAlignmentByName(string name);
}