using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IClassRepository : IRepository<Class, int>
{
    Task<IEnumerable<Class>> GetClassByName(string name);
    Task<IEnumerable<Class>> GetAllPre5EClasses(bool isPre5E);

}