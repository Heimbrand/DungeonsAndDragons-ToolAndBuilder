using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ChallengeRepository : IChallengeRepository
{
    public Task<Challenge> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Challenge>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Challenge>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Challenge> AddAsync(Challenge entity)
    {
        throw new NotImplementedException();
    }

    public Task<Challenge> UpdateAsync(Challenge entity)
    {
        throw new NotImplementedException();
    }

    public Task<Challenge> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}