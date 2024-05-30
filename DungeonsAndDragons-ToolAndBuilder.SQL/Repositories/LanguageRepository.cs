using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class LanguageRepository : ILanguageRepository
{
    public Task<Language> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Language>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Language>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Language> AddAsync(Language entity)
    {
        throw new NotImplementedException();
    }

    public Task<Language> UpdateAsync(Language entity)
    {
        throw new NotImplementedException();
    }

    public Task<Language> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}