using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class AlignmentRepository(DnDbContext context) : IAlignmentRepository
{
    public async Task<Alignment?> GetByIdAsync(int id)
    {
        return await context.Alignments.FindAsync(id);
    }
    public async Task<Alignment> GetAlignmentByName(string name)
    {
        var alignment = await context.Alignments.ToListAsync();

        var FuzzyScored = alignment.Select(x => new
        {
            Alignment = x,
            Score = FuzzySharp.Fuzz.Ratio(name, x.Name)
        });
        return FuzzyScored.OrderByDescending(x => x.Score).First().Alignment;
    }

    public Task<Alignment> GetManyPre5EAlignments(bool isPre5E, int start, int count)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Alignment>> GetAllAsync()
    {
        return await context.Alignments.ToListAsync();
    }
    public async Task<IEnumerable<Alignment>> GetMany(int start, int count)
    {
        return await context.Alignments.Skip(start).Take(count).ToListAsync();
    }
    public async Task AddAsync(Alignment entity)
    {
       await context.Alignments.AddAsync(entity);
       await context.SaveChangesAsync();
       
    }
    public async Task UpdateAsync(Alignment entity)
    {
        var oldEntity = await context.Alignments.FindAsync(entity.Id);
        if (oldEntity == null)
        {
            throw new Exception("Entity not found");
        }

        context.Entry(oldEntity).CurrentValues.SetValues(entity);
        await context.SaveChangesAsync();
        
    }
    public async Task DeleteAsync(int id)
    {
        var entity = await context.Alignments.FindAsync(id);
        if (entity == null)
        {
            throw new Exception("Entity not found");
        }
        context.Alignments.Remove(entity);
        await context.SaveChangesAsync();
    }
}