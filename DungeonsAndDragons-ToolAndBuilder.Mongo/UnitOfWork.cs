
using MongoDB.Driver;

namespace DungeonsAndDragons_ToolAndBuilder.Mongo;

public sealed class UnitOfWork : IUnitOfWork
{
    private IClientSessionHandle session { get; }
    public IDisposable Session => session;

    private List<Action> _operations { get; set; }

    public UnitOfWork()
    {
        var mongoClient = new MongoClient("mongodb://localhost:27017");
        session = mongoClient.StartSession();
        _operations = new List<Action>();
    }
    public void AddOperation(Action operation)
    {
        _operations.Add(operation);
    }
    public void CleanOperations()
    {
        _operations.Clear();
    }
    public async Task CommitChanges()
    {
        session.StartTransaction();
        _operations.ForEach(o =>
        {
            o.Invoke();
        });

        await session.CommitTransactionAsync();
        CleanOperations();

    }
}