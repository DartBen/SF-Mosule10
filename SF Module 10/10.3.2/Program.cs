internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
public interface ICreatable
{
    void Create();
}

public interface IDeletable
{
    void Delete();
}

public interface IUpdatable
{
    void Update();
}

class Entity : ICreatable, IDeletable, IUpdatable
{
    public void Create()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}