using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DungeonsAndDragons_ToolAndBuilder.Mongo;

public interface IUnitOfWork
{
    IDisposable Session { get; }
    void AddOperation(Action operation);
    void CleanOperations();
    Task CommitChanges();
}