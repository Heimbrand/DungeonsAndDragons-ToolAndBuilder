using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IConditionRepository : IRepository<Condition, int>
{
    Task<IEnumerable<Condition>> GetConditionByName(string name);
    Task<IEnumerable<Condition>> GetManyPre5EConditions(int start, int count);
}