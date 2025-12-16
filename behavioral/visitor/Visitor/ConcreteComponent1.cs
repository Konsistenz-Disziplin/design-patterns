namespace Visitor;

public class ConcreteComponent1 : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitComponent1(this);
    }
    public void Do1()
    {
        Console.WriteLine("ConcreteComponent1 doing");
    }
}
