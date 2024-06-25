using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class QuestItemRepository(DnDbContext context) : IQuestItemRepository
{
    public async Task<QuestItem> GetByIdAsync(int id)
    {
        var questItemById = await context.QuestItems.FindAsync(id);

        if (questItemById is null)
            throw new Exception("No QuestItem found with that ID");

        return questItemById;
    }

    public async Task<IEnumerable<QuestItem>> GetAllAsync()
    {
        var allQuestItems = await context.QuestItems.ToListAsync();

        if (allQuestItems is null)
            throw new Exception("No QuestItems found");

        return allQuestItems;
    }

    public async Task<IEnumerable<QuestItem>> GetMany(int start, int count)
    {
        var getManyQuestItems = await context.QuestItems.Skip(start).Take(count).ToListAsync();

        if (getManyQuestItems is null)
            throw new Exception("No QuestItems found");

        return getManyQuestItems;
    }

    public async Task AddAsync(QuestItem entity)
    {
        var addQuestItem = await context.QuestItems.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(QuestItem entity)
    {
        var oldQuestItem = await context.QuestItems.FindAsync(entity.Id);

        if (oldQuestItem is null)
            throw new Exception("No QuestItem found with that ID");

        context.Entry(oldQuestItem).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var questItemToDelete = await context.QuestItems.FindAsync(id);

        if (questItemToDelete is null)
            throw new Exception("No QuestItem found with that ID");

        context.QuestItems.Remove(questItemToDelete);
        context.SaveChangesAsync();
    }
}