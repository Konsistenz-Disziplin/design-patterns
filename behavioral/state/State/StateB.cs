namespace State;

public class StateB : StateBase
{
    public override void Handle2()
    {
        Console.WriteLine("State B Request 2 : Transitioning to State A");
        this._context.TransitionTo(new StateA());
    }

    public override void Handle1()
    {
        Console.WriteLine("State B Request 1");
    }
}
