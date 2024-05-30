using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ReactionRepository : IReactionRepository
{
    public Task<Reaction> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Reaction>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Reaction>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Reaction> AddAsync(Reaction entity)
    {
        throw new NotImplementedException();
    }

    public Task<Reaction> UpdateAsync(Reaction entity)
    {
        throw new NotImplementedException();
    }

    public Task<Reaction> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}