namespace Proxy;

public class ProxyConcrete : ISubject
{
    private RealSubject _realSubject;
    public ProxyConcrete(RealSubject subject)
    {
        this._realSubject = subject;
    }
    public bool CheckAccess()
    {
        Console.WriteLine("Proxy : Checking access");
        return true;
    }
    public void LogAccess()
    {
         Console.WriteLine("Proxy : Logging");
    }
    public void Request()
    {
        Console.WriteLine("Proxy : Handling request");
        if (this.CheckAccess())
        {
            this._realSubject.Request();
            this.LogAccess();
        }
        
    }

}
