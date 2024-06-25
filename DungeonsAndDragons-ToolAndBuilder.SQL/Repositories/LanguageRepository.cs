using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class LanguageRepository(DnDbContext context) : ILanguageRepository
{
    public async Task<Language> GetByIdAsync(int id)
    {
        var languageById = await context.Languages.FindAsync(id);

        if (languageById is null)
            throw new Exception("No Language found with that ID");

        return languageById;
    }

    public async Task<IEnumerable<Language>> GetAllAsync()
    {
        var allLanguages = await context.Languages.ToListAsync();

        if (allLanguages is null)
            throw new Exception("No Languages found");

        return allLanguages;
    }

    public async Task<IEnumerable<Language>> GetMany(int start, int count)
    {
        var getManyLanguages = await context.Languages.Skip(start).Take(count).ToListAsync();

        if (getManyLanguages is null)
            throw new Exception("No Languages found");

        return getManyLanguages;
    }

    public async Task AddAsync(Language entity)
    {
        var addLanguage = await context.Languages.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Language entity)
    {
        var oldLanguage = await context.Languages.FindAsync(entity.Id);

        if (oldLanguage is null)
            throw new Exception("No Language found with that ID");

        context.Entry(oldLanguage).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var languageToDelete = await context.Languages.FindAsync(id);

        if (languageToDelete is null)
            throw new Exception("No Language found with that ID");

        context.Languages.Remove(languageToDelete);
        context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Language>> GetLanguagesByNpcId(int NpcId)
    {
        var languagesByNpcId = await context.Languages.Where(l => l.NpcId == NpcId).ToListAsync();
        return languagesByNpcId;
    }

    public async Task<IEnumerable<Language>> GetLanguagesByCharacterId(int characterId)
    {
        var languagesByCharacterId = await context.Languages.Where(l => l.CharacterId == characterId).ToListAsync();
        return languagesByCharacterId;
    }
}