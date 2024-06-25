using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SkillRepository(DnDbContext context) : ISkillRepository
{
    public async Task<Skill> GetByIdAsync(int id)
    {
        var skillById = await context.Skills.FindAsync(id);

        if (skillById is null)
            throw new Exception("No Skill found with that ID");

        return skillById;
    }

    public async Task<IEnumerable<Skill>> GetAllAsync()
    {
        var allSkills = await context.Skills.ToListAsync();

        if (allSkills is null)
            throw new Exception("No Skills found");

        return allSkills;
    }

    public async Task<IEnumerable<Skill>> GetMany(int start, int count)
    {
        var getManySkills = await context.Skills.Skip(start).Take(count).ToListAsync();

        if (getManySkills is null)
            throw new Exception("No Skills found");

        return getManySkills;
    }

    public async Task AddAsync(Skill entity)
    {
        var addSkill = await context.Skills.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Skill entity)
    {
       var oldSkill = await context.Skills.FindAsync(entity.Id);

       if (oldSkill is null)
              throw new Exception("No Skill found with that ID");

       context.Entry(oldSkill).CurrentValues.SetValues(entity);
       context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var skillToDelete = await context.Skills.FindAsync(id);

        if (skillToDelete is null)
            throw new Exception("No Skill found with that ID");

        context.Skills.Remove(skillToDelete);
    }

    public async Task<IEnumerable<Skill>> GetSkillsByCharacterId(int characterId)
    {
        var skillsByCharacterId = await context.Skills.Where(s => s.CharacterId == characterId).ToListAsync();

        if (skillsByCharacterId is null)
            throw new Exception("No Skills found for that Character");

        return skillsByCharacterId;
    }
}