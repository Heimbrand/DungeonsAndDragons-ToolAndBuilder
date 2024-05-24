using MongoDB.Bson;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

public interface ISqlRepository<T> where T : class
{
    Task GetByIdAsync<T>(ObjectId id);
    Task<List<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(ObjectId id);

}