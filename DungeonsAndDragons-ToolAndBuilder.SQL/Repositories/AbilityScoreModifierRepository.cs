using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class AbilityScoreModifierRepository : IAbilityScoreModifierRepository
{
    public Task<AbilityScoreModifier> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AbilityScoreModifier>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AbilityScoreModifier>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<AbilityScoreModifier> AddAsync(AbilityScoreModifier entity)
    {
        throw new NotImplementedException();
    }

    public Task<AbilityScoreModifier> UpdateAsync(AbilityScoreModifier entity)
    {
        throw new NotImplementedException();
    }

    public Task<AbilityScoreModifier> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}