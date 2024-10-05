using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class AlignmentRepository(DnDbContext context) : IAlignmentRepository
{
    public async Task<Alignment> GetByIdAsync(int id)
    { 
        var alignment = await context.Alignments.FindAsync(id);

        if (alignment is null)
            throw new Exception("No Alignment with that ID exists");
        
        return alignment;
    }
    public async Task<IEnumerable<Alignment>> GetAlignmentByName(string name)
    {
        var alignment = await context.Alignments.ToListAsync();

        if (alignment is null)
            throw new Exception("No Alignment with that name exists");

        var fuzzyScored = alignment.Select(x => new
        {
            Alignment = x,
            Score = FuzzySharp.Fuzz.Ratio(name, x.Name)
        })
            .Where(c => c.Score > 80)
            .OrderByDescending(c => c.Score)
            .Select(c => c.Alignment);

        return fuzzyScored;
    }
 
    public async Task<IEnumerable<Alignment>> GetAllAsync()
    {
        var alignments = await context.Alignments.ToListAsync();

        if (alignments is null)
            throw new Exception("No Alignments where found");

        return alignments;
    }
    public async Task<IEnumerable<Alignment>> GetMany(int start, int count)
    {
        var manyAlignments = await context.Alignments.Skip(start).Take(count).ToListAsync();

        if (manyAlignments is null)
            throw new Exception("No Alignments where found");

        return manyAlignments;
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
            throw new Exception("No Alignment with that ID where found");
        }

        context.Entry(oldEntity).CurrentValues.SetValues(entity);
        await context.SaveChangesAsync();
        
    }
    public async Task DeleteAsync(int id)
    {
        var entity = await context.Alignments.FindAsync(id);
        if (entity == null)
        {
            throw new Exception("No Alignment with that ID where found");
        }
        context.Alignments.Remove(entity);
        await context.SaveChangesAsync();
    }
}