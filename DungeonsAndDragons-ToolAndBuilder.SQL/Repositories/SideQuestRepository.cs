using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SideQuestRepository : ISideQuestRepository
{
    public Task<SideQuest> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SideQuest>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SideQuest>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<SideQuest> AddAsync(SideQuest entity)
    {
        throw new NotImplementedException();
    }

    public Task<SideQuest> UpdateAsync(SideQuest entity)
    {
        throw new NotImplementedException();
    }

    public Task<SideQuest> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}