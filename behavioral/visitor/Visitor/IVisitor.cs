namespace Visitor;

public interface IVisitor
{
    public void VisitComponent1(ConcreteComponent1 comp1);
    public void VisitComponent2(ConcreteComponent2 comp2);
}
