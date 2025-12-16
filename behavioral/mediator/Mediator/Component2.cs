namespace Mediator;

public class Component2 : BaseComponent
{
    public void DoC(){
        Console.WriteLine("Component 2 will do C");
        this._mediator.Notify(this,"C");
    }

    public void DoD(){
        Console.WriteLine("Component 2 will do D");
        this._mediator.Notify(this,"D");
    }
}
