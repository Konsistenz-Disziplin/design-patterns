namespace Visitor;

public class ConcreteVisitor1 : IVisitor
{

    public void VisitComponent1(ConcreteComponent1 comp1)
    { 
        Console.WriteLine("Visitor 1 visiting Component 1");
        comp1.Do1();
    }
    public void VisitComponent2(ConcreteComponent2 comp2)
    {
        Console.WriteLine("Visitor 1 visiting Component 2");
        comp2.Do2();
    }
}
