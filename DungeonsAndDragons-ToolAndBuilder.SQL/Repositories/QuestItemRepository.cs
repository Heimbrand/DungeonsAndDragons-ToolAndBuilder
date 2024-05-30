using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class QuestItemRepository : IQuestItemRepository
{
    public Task<QuestItem> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<QuestItem>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<QuestItem>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<QuestItem> AddAsync(QuestItem entity)
    {
        throw new NotImplementedException();
    }

    public Task<QuestItem> UpdateAsync(QuestItem entity)
    {
        throw new NotImplementedException();
    }

    public Task<QuestItem> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}