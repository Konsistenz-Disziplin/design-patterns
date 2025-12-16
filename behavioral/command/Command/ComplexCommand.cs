namespace Command;

public class ComplexCommand : ICommand
{
    private string _commandA = string.Empty;
    private string _commandB = string.Empty;

    private Receiver _commandReceiver;
    public ComplexCommand(string commandA, string commandB, Receiver receiver)
    {
        this._commandA = commandA;
        this._commandB = commandB;
        this._commandReceiver = receiver;
    }

    public void Execute()
    {
        Console.WriteLine($"Sending to receiver");
        this._commandReceiver.ExecuteA(this._commandA);
        this._commandReceiver.ExecuteB(this._commandB);
        
    }
}
