namespace Adapter;

public class AdapterConcrete : ITarget
{
    private readonly Adaptee _adaptee;
    public AdapterConcrete(Adaptee adaptee)
    {
        this._adaptee = adaptee;
    }
    public string Do()
    {
        Console.WriteLine("Adapter doing");
        return $"{_adaptee.DoSpecific()}";
    }

}
