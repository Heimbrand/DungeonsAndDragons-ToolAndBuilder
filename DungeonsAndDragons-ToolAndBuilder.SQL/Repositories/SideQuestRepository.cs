using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SideQuestRepository(DnDbContext context) : ISideQuestRepository
{
    public async Task<SideQuest> GetByIdAsync(int id)
    {
        var sideQuestById = await context.SideQuests.FindAsync(id);

        if (sideQuestById is null)
            throw new Exception("No SideQuest found with that ID");

        return sideQuestById;
    }

    public async Task<IEnumerable<SideQuest>> GetAllAsync()
    {
        var allSideQuests = await context.SideQuests.ToListAsync();

        if (allSideQuests is null)
            throw new Exception("No SideQuests found");

        return allSideQuests;
    }

    public async Task<IEnumerable<SideQuest>> GetMany(int start, int count)
    {
        var getManySideQuests = await context.SideQuests.Skip(start).Take(count).ToListAsync();

        if (getManySideQuests is null)
            throw new Exception("No SideQuests found");


        return getManySideQuests;
    }

    public async Task AddAsync(SideQuest entity)
    {
        var addSideQuest = await context.SideQuests.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(SideQuest entity)
    {
        var oldSideQuest = await context.SideQuests.FindAsync(entity.Id);

        if (oldSideQuest is null)
            throw new Exception("No SideQuest found with that ID");

        context.Entry(oldSideQuest).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var sideQuestToDelete = await context.SideQuests.FindAsync(id);

        if (sideQuestToDelete is null)
            throw new Exception("No SideQuest found with that ID");

        context.SideQuests.Remove(sideQuestToDelete);
        context.SaveChangesAsync();
    }

    public async Task<IEnumerable<SideQuest>> GetSideQuestByName(string name)
    {
        var sideQuestByName = await context.SideQuests.ToListAsync();

        var fuzzyScored = sideQuestByName.Select(x => new
        {
            SideQuest = x,
            Score = FuzzySharp.Fuzz.PartialRatio(x.Name, name)
        })
            .Where(x => x.Score > 80)
            .OrderByDescending(x => x.Score)
            .Select(x => x.SideQuest);

        return fuzzyScored;
    }

    public async Task<IEnumerable<SideQuest>> GetSideQuestByRecommendedLevel(int RecommendedLevel)
    {
        var sideQuestsByRecommendedLevel = await context.SideQuests.Where(s => s.RecommendedLevel == RecommendedLevel).ToListAsync();

        if (sideQuestsByRecommendedLevel is null)
            throw new Exception("No SideQuests found with that Recommended Level");

        return sideQuestsByRecommendedLevel;
    }
}