namespace State;

public class StateA : StateBase
{
    public override void Handle1()
    {
        Console.WriteLine("State A Request 1 : Transitioning to State B");
        this._context.TransitionTo(new StateB());
    }

    public override void Handle2()
    {
        Console.WriteLine("State A Request 2");
    }
}
