using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IMagicalArtifactRepository : IRepository<MagicalArtifact, int>
{
    Task<IEnumerable<MagicalArtifact>> GetMagicalArtifactByName(string name);
    Task<IEnumerable<MagicalArtifact>> GetManyPre5EMagicalArtifacts(int start, int count);
}