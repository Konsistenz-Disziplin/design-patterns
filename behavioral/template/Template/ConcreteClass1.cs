namespace Template;

public class ConcreteClass1 : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine("ConcreteClass1 Doing RequiredOperation1" );
    }
    protected override void RequiredOperation2()
    {
        Console.WriteLine("ConcreteClass1 Doing RequiredOperation2" );
    }

}
