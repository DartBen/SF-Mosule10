﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
public interface IBook
{
    void Read();
}

public interface IDevice
{
    void TurnOn();
    void TurnOff();
}
class ElectronicBook : IBook, IDevice
{
    void IBook.Read()
    {
        throw new NotImplementedException();
    }

    void IDevice.TurnOff()
    {
        throw new NotImplementedException();
    }

    void IDevice.TurnOn()
    {
        throw new NotImplementedException();
    }
}