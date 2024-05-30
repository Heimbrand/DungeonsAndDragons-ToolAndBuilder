using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class CharacterRepository : ICharacterRepository
{
    public Task<Character> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Character>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Character>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Character> AddAsync(Character entity)
    {
        throw new NotImplementedException();
    }

    public Task<Character> UpdateAsync(Character entity)
    {
        throw new NotImplementedException();
    }

    public Task<Character> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}