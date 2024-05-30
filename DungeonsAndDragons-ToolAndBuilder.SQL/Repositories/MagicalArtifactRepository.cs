using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class MagicalArtifactRepository : IMagicalArtifactRepository
{
    public Task<MagicalArtifact> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MagicalArtifact>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MagicalArtifact>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<MagicalArtifact> AddAsync(MagicalArtifact entity)
    {
        throw new NotImplementedException();
    }

    public Task<MagicalArtifact> UpdateAsync(MagicalArtifact entity)
    {
        throw new NotImplementedException();
    }

    public Task<MagicalArtifact> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}