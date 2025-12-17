namespace Decorator;

public class FileDataSource : IDataSource
{
    public void WriteData(string data)
    {
        Console.WriteLine($"FileDataSource is writing : {data}");
    }
}
