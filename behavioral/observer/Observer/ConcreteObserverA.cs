namespace Observer;

public class ConcreteObserverA : IObserver
{
    public void ReceiveUpdate(ISubject subject)
    {
        if((subject as Subject).State < 3)
        {
            Console.WriteLine("Observer A : will react to event");
        }
    }
}
