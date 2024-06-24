using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ConditionRepository(DnDbContext context) : IConditionRepository
{
    public async Task<Condition> GetByIdAsync(int id)
    {
        var conditionById = await context.Conditions.FindAsync(id);

        if (conditionById is null)
            throw new Exception("No Condition found with that ID");

        return conditionById;
    }
    public async Task<IEnumerable<Condition>> GetAllAsync()
    {
        var allConditions = await context.Conditions.ToListAsync();

        if (allConditions is null)
            throw new Exception("No conditions found");

        return allConditions;
    }
    public async Task<IEnumerable<Condition>> GetMany(int start, int count)
    {
        var getManyConditions = await context.Conditions.Skip(start).Take(count).ToListAsync();

        if (getManyConditions is null)
            throw new Exception("No conditions found");

        return getManyConditions;
    }
    public async Task AddAsync(Condition entity)
    {
        var addCondition = await context.Conditions.AddAsync(entity);
    }
    public async Task UpdateAsync(Condition entity)
    {
        var oldCondition = await context.Conditions.FindAsync(entity.Id);

        if (oldCondition is null)
            throw new Exception("Condition not found");

        context.Entry(oldCondition).CurrentValues.SetValues(entity);
        context.SaveChanges();

    }
    public async Task DeleteAsync(int id)
    {
        var deleteCondition = await context.Conditions.FindAsync(id);

        if (deleteCondition is null)
            throw new Exception("Condition not found");

        context.Conditions.Remove(deleteCondition);
        context.SaveChanges();
    }
    public async Task<IEnumerable<Condition>> GetConditionByName(string name)
    {
         var conditionByName = await context.Conditions.ToListAsync();

        var fuzzyScore = conditionByName.Select(x => new
        {
            Condition = x,
            Score = FuzzySharp.Fuzz.PartialRatio(x.Name, name)
        })
            .Where(x => x.Score > 80)
            .OrderByDescending(x => x.Score)
            .Select(x => x.Condition);
        return conditionByName; 
    }
    public async Task<IEnumerable<Condition>> GetManyPre5EConditions(int start, int count)
    {
        var pre5EConditions = await context.Conditions.Where(c=>c.IsPre5E == true).Skip(start).Take(count).ToListAsync();

        if (pre5EConditions is null)
            throw new Exception("No pre-5E conditions found");

        return pre5EConditions;
    }
}