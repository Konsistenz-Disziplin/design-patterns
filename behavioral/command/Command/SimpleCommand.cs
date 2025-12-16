namespace Command;

public class SimpleCommand : ICommand
{
    private string _myCommand = string.Empty;

    public SimpleCommand(string command)
    {
        this._myCommand = command;
    }
    public void Execute()
    {
        Console.WriteLine($"Executing : {this._myCommand}");
    }
}
