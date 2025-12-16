namespace Mediator;

public class ComponentMediator : IMediator
{
    private Component1 _component1;
    private Component2 _component2;

    public ComponentMediator(Component1 comp1, Component2 comp2){
        this._component1 = comp1;
        this._component1.SetMediator(this);
        this._component2 = comp2;
        this._component2.SetMediator(this);
    }

    public void Notify(object sender , string eventName){
        Console.WriteLine("Meditor will notify");
        if(sender is Component1 && eventName.Equals("A", StringComparison.OrdinalIgnoreCase)){
           
           this._component2.DoC();
        }
        else if(sender is Component2 && eventName.Equals("D", StringComparison.OrdinalIgnoreCase)){
            this._component1.DoB();
            this._component2.DoC();
        }
    }
}
