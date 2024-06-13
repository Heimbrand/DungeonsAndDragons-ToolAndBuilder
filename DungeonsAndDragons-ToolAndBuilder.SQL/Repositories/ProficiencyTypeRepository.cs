using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ProficiencyTypeRepository : IProficiencyTypeRepository
{
    public Task<ProficiencyType> AddAsync(ProficiencyType entity)
    {
        throw new NotImplementedException();
    }

    public Task<ProficiencyType> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProficiencyType>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProficiencyType> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProficiencyType>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<ProficiencyType> UpdateAsync(ProficiencyType entity)
    {
        throw new NotImplementedException();
    }
}