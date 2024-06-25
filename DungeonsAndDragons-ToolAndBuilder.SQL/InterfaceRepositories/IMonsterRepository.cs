using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IMonsterRepository : IRepository<Monster, int>
{
    Task<IEnumerable<Monster>> GetMonsterByName(string name);
    Task<IEnumerable<Monster>> GetMonstersByChallengeRating(int challengeRating);
    Task<IEnumerable<Monster>> GetMonstersByType(string type);
    Task<IEnumerable<Monster>> GetMonstersBySize(string size);
    Task<IEnumerable<Monster>> GetMonstersByAlignment(string alignment);
    Task<IEnumerable<Monster>> GetMonstersByEnvironment(string environment);
    Task<IEnumerable<Monster>> GetManyPre5EMonsters();
}