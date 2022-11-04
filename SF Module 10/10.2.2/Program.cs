internal class Program
{
    private static void Main(string[] args)
    {
        Writer writer = new Writer();
        ((IWriter)writer).Write();
    }
}

public interface IWriter
{
    void Write();
}

class Writer : IWriter
{
    public void Write()
    { }
}