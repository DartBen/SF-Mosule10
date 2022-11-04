internal class Program
{
    private static void Main(string[] args)
    {
        Work work = new Work();
        work.Build();
    }
}
public interface IWorker
{
    public void Build();
}
class Work : IWorker
{
    public void Build()
    {
        throw new NotImplementedException();
    }
}
