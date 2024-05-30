using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class AbilityScoreScoreRepository : IAbilityScoreRepository
{
    public Task<AbilityScore> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AbilityScore>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AbilityScore>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<AbilityScore> AddAsync(AbilityScore entity)
    {
        throw new NotImplementedException();
    }

    public Task<AbilityScore> UpdateAsync(AbilityScore entity)
    {
        throw new NotImplementedException();
    }

    public Task<AbilityScore> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}