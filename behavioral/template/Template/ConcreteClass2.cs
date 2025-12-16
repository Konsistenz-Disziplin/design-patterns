namespace Template;

public class ConcreteClass2 : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine("ConcreteClass2 Doing RequiredOperation1" );
    }
    protected override void RequiredOperation2()
    {
        Console.WriteLine("ConcreteClass2 Doing RequiredOperation2" );
    }

    protected override void OptionalOperation2()
    {
        Console.WriteLine("ConcreteClass2 Doing OptionalOperation2" );
    }
}
