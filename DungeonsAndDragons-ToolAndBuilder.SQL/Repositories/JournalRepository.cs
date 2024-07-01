using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class JournalRepository(DnDbContext context) : IJournalRepository
{
    public async Task AddAsync(Journal entity)
    {
        var addJournal = await context.Journals.AddAsync(entity);
        context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var journalToDelete = await context.Journals.FindAsync(id);

        if (journalToDelete is null)
            throw new Exception("No Journal found with that ID");

        context.Journals.Remove(journalToDelete);
        context.SaveChangesAsync();
    }
    public async Task<IEnumerable<Journal>> GetAllAsync()
    {
        var allJournals = await context.Journals.ToListAsync();

        if (allJournals is null)
            throw new Exception("No Journals found");

        return allJournals;
    }
    public async Task<Journal> GetByIdAsync(int id)
    {
        var journalById = await context.Journals.FindAsync(id);

        if (journalById is null)
            throw new Exception("No Journal found with that ID");

        return journalById;
    }
    public async Task<IEnumerable<Journal>> GetMany(int start, int count)
    {
        var getManyJournals = await context.Journals.Skip(start).Take(count).ToListAsync();

        if (getManyJournals is null)
            throw new Exception("No Journals found");

        return getManyJournals;
    }
    public async Task UpdateAsync(Journal entity)
    {
        var oldJournal = await context.Journals.FindAsync(entity.Id);

        if (oldJournal is null)
            throw new Exception("No Journal found with that ID");

        context.Entry(oldJournal).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }
}