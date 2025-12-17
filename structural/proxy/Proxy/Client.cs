namespace Proxy;

public static class Client
{
    public static void Do(ISubject subject)
    {
        subject.Request();
    }
}
