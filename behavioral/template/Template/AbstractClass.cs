namespace Template;

public abstract class AbstractClass
{
    protected abstract void RequiredOperation1();
    protected abstract void RequiredOperation2();

    protected virtual void OptionalOperation1(){}
    protected virtual void OptionalOperation2(){}
    protected void BaseOperation1()
    {
        Console.WriteLine("Abstract Doing Base Operation 1");
    }
    public void TemplateMethod()
    {
        this.BaseOperation1();
        this.RequiredOperation1();
        this.OptionalOperation1();
        this.RequiredOperation2();
        this.OptionalOperation2();

    }
}
