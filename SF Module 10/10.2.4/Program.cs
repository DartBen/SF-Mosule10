internal class Program
{
    private static void Main(string[] args)
    {
        Work work = new Work();
        ((IWorker)work).Build();
    }
}
public interface IWorker
{
    public void Build();
}
class Work : IWorker
{
    void IWorker.Build()
    {
        throw new NotImplementedException();
    }
}