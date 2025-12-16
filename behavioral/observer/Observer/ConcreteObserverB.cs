namespace Observer;

public class ConcreteObserverB : IObserver
{
    public void ReceiveUpdate(ISubject subject)
    {
        if((subject as Subject).State == 0 || (subject as Subject).State >=2 )
        {
            Console.WriteLine("Observer B : will react to event");
        }
    }
}
