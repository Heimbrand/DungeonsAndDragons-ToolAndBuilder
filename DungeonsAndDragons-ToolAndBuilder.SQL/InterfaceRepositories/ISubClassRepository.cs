using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface ISubClassRepository : IRepository<SubClass, int>
{
    Task<SubClass> GetSubclassByCharacterId(int id);
    Task<SubClass> GetSubClassByNpcId(int id);
}