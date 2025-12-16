namespace Visitor;

public class Client
{
    public static void Do(List<IComponent> components, IVisitor visitor)
    {
        foreach(var comp in components)
        {
            comp.Accept(visitor);
        }
    }
}
