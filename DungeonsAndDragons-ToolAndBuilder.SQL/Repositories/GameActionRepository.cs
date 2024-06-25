using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class GameActionRepository(DnDbContext context) : IGameActionRepository
{
    public async Task<GameAction> GetByIdAsync(int id)
    {
        var gameActionById = await context.GameActions.FindAsync(id);

        if (gameActionById is null)
            throw new Exception("No GameAction found with that ID");

        return gameActionById;
    }

    public async Task<IEnumerable<GameAction>> GetAllAsync()
    { 
        var getAllGamActions = await context.GameActions.ToListAsync();

        if (getAllGamActions is null)
            throw new Exception("No GameActions found");

        return getAllGamActions;
    }

    public async Task<IEnumerable<GameAction>> GetMany(int start, int count)
    {
        var getManyGameActions = await context.GameActions.Skip(start).Take(count).ToListAsync();

        if (getManyGameActions is null)
            throw new Exception("No GameActions found");

        return getManyGameActions;
    }

    public async Task AddAsync(GameAction entity)
    {
        var addGameAction = await context.GameActions.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(GameAction entity)
    {
        var oldGameAction = await context.GameActions.FindAsync(entity.Id);

        if (oldGameAction is null)
            throw new Exception("No GameAction found with that ID");

        context.Entry(oldGameAction).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var gameActionToDelete = await context.GameActions.FindAsync(id);

        if (gameActionToDelete is null)
            throw new Exception("No GameAction found with that ID");

        context.GameActions.Remove(gameActionToDelete);
        context.SaveChangesAsync();
    }

    public async Task<IEnumerable<GameAction>> GetGameActionByName(string name)
    {
        var gameActionByName = await context.GameActions.ToListAsync();

        var fuzzyScored = gameActionByName.Select(x => new
            {
                Score = FuzzySharp.Fuzz.PartialRatio(x.Name, name),
                GameAction = x
            })
            .Where(x => x.Score > 80)
            .OrderByDescending(x => x.Score)
            .Select(x => x.GameAction);

        return fuzzyScored;
    }

    public async Task<IEnumerable<GameAction>> GetGameActionsByCharacterId(int characterId)
    {
        var gameActionsByCharacterId = await context.GameActions.Where(x => x.CharacterId == characterId).ToListAsync();

        if (gameActionsByCharacterId is null)
            throw new Exception("No GameActions found with that Character ID");

        return gameActionsByCharacterId;
    }

    public async Task<IEnumerable<GameAction>> GetGameActionsByNpcId(int NpcId)
    {
       var gameActionByNpcId = await context.GameActions.Where(x => x.NpcId == NpcId).ToListAsync();

        if (gameActionByNpcId is null)
            throw new Exception("No GameActions found with that NPC ID");

        return gameActionByNpcId;
    }

    public async Task<IEnumerable<GameAction>> GetManyPre5EGameActions(int start, int count)
    {
        var manyPre5EGameActions = await context.GameActions.Where(x => x.IsPre5E == true).Skip(start).Take(count).ToListAsync();

        if (manyPre5EGameActions is null)
            throw new Exception("No Pre-5E GameActions found");

        return manyPre5EGameActions;
    }
}