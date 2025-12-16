namespace ChainofResponsibility;

public class Container : Component
{
    protected List<Component> Children = new List<Component>();
    public void Add(Component child){
        Children.Add(child);
        child.SetContainer(this);
    }

}
