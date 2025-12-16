namespace Observer;

public interface IObserver
{
    void ReceiveUpdate(ISubject subject);

}
