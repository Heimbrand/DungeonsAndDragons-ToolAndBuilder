using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class CharacterRepository(DnDbContext context) : ICharacterRepository
{
    public async Task<Character> GetByIdAsync(int id)
    {
        var characterById = await context.Characters.FindAsync(id);

        if (characterById is null)
            throw new KeyNotFoundException($"Character with the id: {id} not found");

        return characterById;
        
    }
    public async Task<IEnumerable<Character>> GetAllAsync()
    {
        var allCharacters = await context.Characters.ToListAsync();

        if (allCharacters is null)
            throw new Exception("No characters found");

        return allCharacters;
    }
    public async Task<IEnumerable<Character>> GetMany(int start, int count)
    {
        var manyCharacters = await context.Characters.Skip(start).Take(count).ToListAsync();

        if (manyCharacters is null)
            throw new Exception("No characters found");

        return manyCharacters;
    }
    public async Task AddAsync(Character entity)
    {
        var characterToAdd = await context.Characters.AddAsync(entity);
        await context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Character entity)
    {
        var updateCharacter = context.Characters.Update(entity);
        await context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var characterToDelete = await context.Characters.FindAsync(id);

        if (characterToDelete is null)
            throw new Exception("Character not found");

        context.Characters.Remove(characterToDelete);
        await context.SaveChangesAsync();
    }
    public async Task<IEnumerable<Character>> GetCharacterByName(string name)
    {
        var characters = await context.Characters.ToListAsync();

        var fuzzyScored = characters
            .Select(c => new
            {
                Character = c, 
                Score = FuzzySharp.Fuzz.Ratio(c.Name, name)
            })

            .Where(c => c.Score > 80)
            .OrderByDescending(c => c.Score)
            .Select(c => c.Character);

        return fuzzyScored;
    }
    public async Task<IEnumerable<Character>> GetAllLivingCharacters()
    {
        var allLivingCharacters = await context.Characters.Where(c => c.IsDead == false).ToListAsync();

        if (allLivingCharacters is null)
            throw new Exception("No living characters found");

        return allLivingCharacters;
    }
    public async Task<IEnumerable<Character>> GetAllDeadCharacters()
    {
        var allDeadCharacters = await context.Characters.Where(c=>c.IsDead == true).ToListAsync();

        if (allDeadCharacters is null)
            throw new Exception("No dead characters found");

        return allDeadCharacters;
    }
}