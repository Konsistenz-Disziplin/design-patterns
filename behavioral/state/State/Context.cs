namespace State;

public class Context
{
    private StateBase _state;
    public Context(StateBase state)
    {
     this.TransitionTo(state);
    }
    public void TransitionTo(StateBase state)
    {
        Console.WriteLine($"Context transitioning to {state.GetType().Name}");
        this._state = state;
        this._state.SetContext(this);
    }
    public void Request1()
    {
        this._state.Handle1();
    }
        public void Request2()
    {
        this._state.Handle2();
    }
}
