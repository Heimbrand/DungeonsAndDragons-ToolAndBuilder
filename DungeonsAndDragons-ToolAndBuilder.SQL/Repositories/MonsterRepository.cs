using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class MonsterRepository(DnDbContext context) : IMonsterRepository
{
    public async Task<Monster> GetByIdAsync(int id)
    {
        var monsterById = await context.Monsters.FindAsync(id);

        if (monsterById is null)
            throw new Exception("No Monster found with that ID");

        return monsterById;
    }

    public async Task<IEnumerable<Monster>> GetAllAsync()
    {
        var allMonsters = await context.Monsters.OrderByDescending(m => m.ChallengeRating).ToListAsync();

        if (allMonsters is null)
            throw new Exception("No Monsters found");

        return allMonsters;
    }

    public async Task<IEnumerable<Monster>> GetMany(int start, int count)
    {
        var getManyMonsters = await context.Monsters.Skip(start).Take(count).OrderByDescending(m => m.ChallengeRating)
            .ToListAsync();

        if (getManyMonsters is null)
            throw new Exception("No Monsters found");

        return getManyMonsters;
    }

    public async Task AddAsync(Monster entity)
    {
        var addMonster = await context.Monsters.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Monster entity)
    {
        var oldMonster = await context.Monsters.FindAsync(entity.Id);

        if (oldMonster is null)
            throw new Exception("No Monster found with that ID");

        context.Entry(oldMonster).CurrentValues.SetValues(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var monsterToDelete = await context.Monsters.FindAsync(id);

        if (monsterToDelete is null)
            throw new Exception("No Monster found with that ID");

        context.Monsters.Remove(monsterToDelete);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Monster>> GetMonsterByName(string name)
    {
        var monsterByName = await context.Monsters.ToListAsync();

        var fuzzyScored = monsterByName.Select(m => new
            {
                Monster = m, 
                Score = FuzzySharp.Fuzz.PartialRatio(m.Name, name)
            })
            .Where(m => m.Score > 80)
            .OrderByDescending(m => m.Score)
            .Select(m => m.Monster);

        return fuzzyScored;
    }

    public async Task<IEnumerable<Monster>> GetMonstersByChallengeRating(int challengeRating)
    {
        var monstersByChallengeRating = await context.Monsters.Where(m=>m.ChallengeRating == challengeRating).ToListAsync();

        if (monstersByChallengeRating is null)
            throw new Exception("No Monsters found with that Challenge Rating");

        return monstersByChallengeRating;
    }

    public async Task<IEnumerable<Monster>> GetMonstersByType(string type)
    {
       var monsterByType = await context.Monsters.Include(m => m.MonsterType).Where(m => m.MonsterType.Name == type).ToListAsync();

        if (monsterByType is null)
            throw new Exception("No Monsters found with that Type");

        return monsterByType;
    }

    public async Task<IEnumerable<Monster>> GetMonstersBySize(string size)
    {
        var monsterBySize = await context.Monsters.Include(m=>m.Size).Where(m=>m.Size.Name == size).ToListAsync();

        if (monsterBySize is null)
            throw new Exception("No Monsters found with that Size");

        return monsterBySize;
    }

    public async Task<IEnumerable<Monster>> GetMonstersByAlignment(string alignment)
    {
        var monsterByAlignment = await context.Monsters.Include(m=>m.Alignment).Where(m=>m.Alignment.Name == alignment).ToListAsync();

        if (monsterByAlignment is null)
            throw new Exception("No Monsters found with that Alignment");

        return monsterByAlignment;
    }

    public async Task<IEnumerable<Monster>> GetManyPre5EMonsters(int start, int count)
    {
        var getManyPre5EMonsters = await context.Monsters
            .Where(m => m.IsPre5E == true)
            .OrderByDescending(m => m.ChallengeRating)
            .Skip(start)
            .Take(count)
            .ToListAsync();

        if (getManyPre5EMonsters is null)
            throw new Exception("No Pre-5E Monsters found");

        return getManyPre5EMonsters;
    }
}