namespace Command;

public class Receiver
{
    public void ExecuteA( string command)
    {
        Console.WriteLine($"Receiver's Executer A executing {command}");
    }

    public void ExecuteB( string command)
    {
        Console.WriteLine($"Receiver's Executer B executing {command}");
    }
}
