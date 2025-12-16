namespace Observer;

public class Subject : ISubject
{
    public int State = 0;
    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        this._observers.Add(observer);
    }
    public void Detach(IObserver observer)
    {
        this._observers.Remove(observer);
    }
    public void Notify()
    {
        foreach(var obs in this._observers)
        {
            obs.ReceiveUpdate(this);
        }
    }
    public void Do()
    {
        this.State =  new Random().Next(0, 10);
        Thread.Sleep(15);
        Console.WriteLine($"Subject : My state changed to {this.State}..Notifying");
        this.Notify();
    }
}
