using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ReactionRepository(DnDbContext context) : IReactionRepository
{
    public async Task<Reaction> GetByIdAsync(int id)
    {
        var reactionById = await context.Reactions.FindAsync(id);

        if (reactionById is null)
            throw new Exception("No Reaction found with that ID");

        return reactionById;
    }

    public async Task<IEnumerable<Reaction>> GetAllAsync()
    {
        var allReactions = await context.Reactions.ToListAsync();

        if (allReactions is null)
            throw new Exception("No Reactions found");

        return allReactions;
    }

    public async Task<IEnumerable<Reaction>> GetMany(int start, int count)
    {
        var getManyReactions = await context.Reactions.Skip(start).Take(count).ToListAsync();

        if (getManyReactions is null)
            throw new Exception("No Reactions found");

        return getManyReactions;
    }

    public async Task AddAsync(Reaction entity)
    {
       var addReaction = await context.Reactions.AddAsync(entity);
       context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Reaction entity)
    {
        var oldReaction = await context.Reactions.FindAsync(entity.Id);

        if (oldReaction is null)
            throw new Exception("No Reaction found with that ID");

        context.Entry(oldReaction).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var reactionToDelete = await context.Reactions.FindAsync(id);

        if (reactionToDelete is null)
            throw new Exception("No Reaction found with that ID");

        context.Reactions.Remove(reactionToDelete);
        context.SaveChangesAsync();
    }
}