namespace Visitor;

public class ConcreteComponent2 : IComponent
{
    public void Accept(IVisitor visit)
    {
        visit.VisitComponent2(this);
    }

    public void Do2()
    {
        Console.WriteLine("ConcreteComponent2 doing");
    }
}
