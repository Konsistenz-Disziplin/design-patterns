using System.Runtime.CompilerServices;

namespace Command;

public class Invoker
{
    private ICommand _onStart;
    private ICommand _onFinish;

    public void SetOnStart(ICommand command)
    {
        this._onStart = command;
    }

    public void SetOnFinish(ICommand command)
    {
        this._onFinish = command;
    }

    public void Do()
    {
        Console.WriteLine("Invoker will start");
        this._onStart.Execute();
        Console.WriteLine("Invoker will finish");
        this._onFinish.Execute();
        Console.WriteLine("Invoker finished");
    }
}
