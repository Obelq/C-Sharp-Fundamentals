public abstract class Worker
{
    protected Worker(string id)
    {
        Id = id;
    }
    public string Id { get; protected set; }
}
