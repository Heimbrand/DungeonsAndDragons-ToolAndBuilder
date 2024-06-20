using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IAlignmentRepository : IRepository<Alignment, int>
{
    Task<IEnumerable<Alignment>> GetAlignmentByName(string name);
    Task<IEnumerable<Alignment>> GetManyPre5EAlignments( int start, int count);
}