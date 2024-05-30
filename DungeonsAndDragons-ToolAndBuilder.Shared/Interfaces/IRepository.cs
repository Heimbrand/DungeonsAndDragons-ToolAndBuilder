using MongoDB.Bson;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

public interface IRepository<IEntity, TId> where IEntity : IEntity<TId>
{
    Task<IEntity> GetByIdAsync(TId id);
    Task<IEnumerable<IEntity>> GetAllAsync();
    Task<IEnumerable<IEntity>> GetMany(int start, int count);
    Task<IEntity> AddAsync(IEntity entity);
    Task<IEntity> UpdateAsync(IEntity entity);
    Task<IEntity> DeleteAsync(TId id);
}
