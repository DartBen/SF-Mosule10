internal class Program
{
    private static void Main(string[] args)
    {
        IWriter writer = new FileManager();
        IReader reader = new FileManager();
        IMailer mailer = new FileManager();

        writer.Write();
        reader.Read();
        mailer.SendEmail();

        FileManager fileManager = new FileManager();
        ((IWriter)fileManager).Write();
        ((IReader)fileManager).Read();
        ((IMailer)fileManager).SendEmail();

    }
}

public interface IWriter
{
    void Write();
}

public interface IReader
{
    void Read();
}

public interface IMailer
{
    void SendEmail();
}

class FileManager : IWriter, IReader, IMailer
{
    void IReader.Read()
    {
        throw new NotImplementedException();
    }

    void IMailer.SendEmail()
    {
        throw new NotImplementedException();
    }

    void IWriter.Write()
    {
        throw new NotImplementedException();
    }
}